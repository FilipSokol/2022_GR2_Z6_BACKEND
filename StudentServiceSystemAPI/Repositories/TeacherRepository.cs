using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentServiceSystemAPI.Data;
using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;

namespace StudentServiceSystemAPI.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly ILogger<DepartmentRepository> logger;
        private readonly IDepartmentRepository departmentRepository;

        public TeacherRepository(ApplicationDbContext context, IMapper mapper, ILogger<DepartmentRepository> logger)
        {
            this.context = context;
            this.mapper = mapper;
            this.logger = logger;
        }

        public async Task<int> Create(int departmentId, CreateTeacherDto dto)
        {
            var department = await this.context.Departments.FirstOrDefaultAsync(x => x.DepartmentId == departmentId);
            
            if (department == null) throw new NullReferenceException("Department does not exist.");

            var teacher = this.mapper.Map<Teacher>(dto);

            var user = await this.context.Users.FirstOrDefaultAsync(x => x.Email == teacher.Email);

            if (user is null)
            {
                throw new NullReferenceException($"User does not exist.");
            }

            user.RoleId = 2;

            department.Teachers = department.Teachers ?? new List<Teacher>();

            department.Teachers.Add(teacher);
            await this.context.SaveChangesAsync();

            return teacher.TeacherId;
        }

        public async Task Delete(int id)
        {
            var teacher = this.context
            .Teachers
                .FirstOrDefault(e => e.TeacherId == id);

            if (teacher == null) throw new Exception("Teacher not found");

            this.context.Remove(teacher);
            await this.context.SaveChangesAsync();
        }

        public async Task<List<Teacher>> GetAll()
        {
            var teachers = await this.context
                 .Teachers
                 .ToListAsync();

            return teachers;
        }

        public async Task<List<Teacher>> GetByDepartmentId(int departmentId)
        {
            var teachers = await this.context
                 .Teachers
                 .Where(x => x.DepartmentId == departmentId)
                 .ToListAsync();

            return teachers;
        }

        public async Task<Teacher> GetById(int id)
        {
            var teacher = await this.context
                .Teachers
                .FirstOrDefaultAsync(x => x.TeacherId == id);

            if (teacher is null) throw new NullReferenceException("Teacher does not exist");

            return teacher;
        }

        public async Task Update(int id, UpdateTeacherDto dto)
        {
            var teacher = await this.context
                .Teachers
                .FirstOrDefaultAsync(d => d.TeacherId == id);

            if (teacher is null) throw new NullReferenceException("Teacher not found");

            teacher.FirstName = dto.FirstName;
            teacher.LastName = dto.LastName;
            teacher.Email = dto.Email;
            if (dto.DepartmentId == 0)
            {
                var department = await this.context.Departments.FirstOrDefaultAsync(x => x.DepartmentId == teacher.DepartmentId);

                if (department is null) throw new NullReferenceException("Department not found");

                department.Teachers.Remove(teacher);

                teacher.DepartmentId = dto.DepartmentId;
            }
            else
            {

                var department = await this.context.Departments.FirstOrDefaultAsync(x => x.DepartmentId == dto.DepartmentId);

                if (department is null) throw new NullReferenceException("Department not found");
          
                teacher.DepartmentId = dto.DepartmentId;

                department.Teachers = department.Teachers ?? new List<Teacher>();

                department.Teachers.Add(teacher);
            }

            await this.context.SaveChangesAsync();
        }

        public async Task AssignSubject(int teacherId, int subjectId)
        {
            var subject = await this.context.Subjects.FirstOrDefaultAsync(x => x.SubjectId == subjectId);

            if (subject is null) throw new NullReferenceException("Subject not found");

            subject.TeacherId = teacherId;
         
            await this.context.SaveChangesAsync();
        }
        public async Task UnassignSubject(int teacherId, int subjectId)
        {
            var subject = await this.context.Subjects.FirstOrDefaultAsync(x => x.SubjectId == subjectId && x.TeacherId == teacherId);

            if (subject is null) throw new NullReferenceException("Subject not found");

            subject.TeacherId = null;

            await this.context.SaveChangesAsync();
        }

        public async Task<List<int>> GetAllTeacherGroups(int teacherId)
        {
            var groupIds = await this.context
                .Subjects
                .Where(x => x.TeacherId == teacherId)
                .Select(x => (int) x.ScheduleId)
                .ToListAsync();


            if (groupIds == null)
            {
                throw new NullReferenceException("Groups not found");
            }

            var groups = await this.context
                .Groups
                .Where(x => groupIds.Contains(x.GroupId))
                .ToListAsync();

            if (groups == null)
            {
                throw new NullReferenceException("Groups not found");
            }

            return groups.Select(x => x.GroupId).ToList();
        }
    }
}
