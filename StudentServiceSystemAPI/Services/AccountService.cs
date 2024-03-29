﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using StudentServiceSystemAPI.Data;
using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace StudentServiceSystemAPI.Services
{
    public class AccountService : IAccountService
    {
        private readonly ApplicationDbContext _context;
        private readonly IPasswordHasher<User> _passwordHasher;
        private readonly AuthenticationSettings _authenticationSettings;

        public AccountService(ApplicationDbContext context, IPasswordHasher<User> passwordHasher, AuthenticationSettings authenticationSettings)
        {
            _context = context;
            _passwordHasher = passwordHasher;
            _authenticationSettings = authenticationSettings;
        }

        public string GenerateJwt(LoginDto dto)
        {
            var user = _context.Users
                 .Include(user => user.Role)
                 .FirstOrDefault(u => u.Email == dto.Email);

            if (user == null)
            {
                throw new Exception("Invalid username or password");
            }

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Role, $"{user.Role.Name}")
            };


            if (user.Role.Name == "Student")
            {
                var student = _context.Students.FirstOrDefault(x => x.Email == dto.Email);

                if (student == null)
                {
                    throw new Exception("There is no student with provided email.");
                }

                var group = _context.Groups.FirstOrDefault(x => x.GroupId == student.GroupId);

                if (group == null)
                {
                    throw new Exception("Such group does not exist.");
                }

                claims.Add(new Claim("DepartmentId", group.DepartmentId.ToString()));
                claims.Add(new Claim("GroupId", student.GroupId.ToString()));
                claims.Add(new Claim("StudentId", student.StudentId.ToString()));
                claims.Add(new Claim(ClaimTypes.Name, $"{student.FirstName} {student.LastName}"));
            }

            if (user.Role.Name == "Teacher")
            {
                var teacher = _context.Teachers.FirstOrDefault(x => x.Email == dto.Email);
                
                if (teacher == null)
                {
                    throw new Exception("There is no teacher with provided email.");
                }

                var department = _context.Departments.FirstOrDefault(x => x.DepartmentId == teacher.DepartmentId);

                if (department == null)
                {
                    throw new Exception("Such department does not exist.");
                }

                claims.Add(new Claim("DepartmentId", teacher.DepartmentId.ToString()));
                claims.Add(new Claim("TeacherId", teacher.TeacherId.ToString()));
                claims.Add(new Claim(ClaimTypes.Name, $"{teacher.FirstName} {teacher.LastName}"));

            }
            
            var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, dto.Password);

            if (result == PasswordVerificationResult.Failed)
            {
                throw new Exception("Invalid username or password");
            }

  

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_authenticationSettings.JwtKey));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(_authenticationSettings.JwtExpireDays);

            var token = new JwtSecurityToken(_authenticationSettings.JwtIssuer,
                _authenticationSettings.JwtIssuer,
                claims,
                expires: expires,
                signingCredentials: cred);

            var tokenHandler = new JwtSecurityTokenHandler();

            return tokenHandler.WriteToken(token);
        }

        public void RegisterUser(RegisterUserDto dto)
        {
            var newUser = new User()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                DateOfBirth = dto.DateOfBirth,
                Nationality = dto.Nationality,
                Province = dto.Province,
                PasswordHash = dto.Password,
                RoleId = dto.RoleId
            };

            var hashedPassword = _passwordHasher.HashPassword(newUser, dto.Password);

            newUser.PasswordHash = hashedPassword;

            _context.Users.Add(newUser);
            _context.SaveChanges();

        }

        public async Task ChangeRole(int userId, string role)
        {
            var user = await this._context.Users.FirstOrDefaultAsync(x => x.Id == userId);

            if (user is null)
            {
                throw new NullReferenceException($"User with id {userId} does not exist.");
            }

            var userRole = await this._context.Roles.FirstOrDefaultAsync(x => x.Name == role);

            if (userRole is null)
            {
                throw new NullReferenceException($"User role {role} does not exist.");
            }

            user.RoleId = userRole.Id;

            var student = await this._context
                .Students
                .FirstOrDefaultAsync(x => x.Email == user.Email);

            var teacher = await this._context
                .Teachers
                .FirstOrDefaultAsync(x => x.Email == user.Email);

            if (student is null && teacher is not null)
            {
                student = new Student()
                {
                    GroupId = 1,
                    FirstName = teacher.FirstName,
                    LastName = teacher.LastName,
                    Email = teacher.Email,
                    Marks = new List<Mark>()
                };

                await _context.Students.AddAsync(student);
                _context.Teachers.Remove(teacher);
            }

            if (teacher is null && student is not null)
            {
                teacher = new Teacher()
                {
                    DepartmentId = 1,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Email = student.Email,
                    Subjects = new List<Subject>()
                };

                await _context.Teachers.AddAsync(teacher);
                _context.Students.Remove(student);
            }

            if (teacher is null && student is null)
            {
                throw new InvalidOperationException("Either teacher and student are not exists.");
            }

            await _context.SaveChangesAsync();
        }
    }
}
