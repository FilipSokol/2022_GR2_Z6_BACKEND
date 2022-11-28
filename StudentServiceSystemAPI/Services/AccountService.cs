using Microsoft.AspNetCore.Identity;
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
                new Claim(ClaimTypes.Name, $"{user.FirstName} {user.LastName}"),
                new Claim(ClaimTypes.Role, $"{user.Role.Name}"),
                new Claim("DateOfBirth", user.DateOfBirth.Value.ToString("yyyy-MM-dd")),
                new Claim("Province", user.Province),
                new Claim("Nationality", user.Nationality),
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
    }
}
