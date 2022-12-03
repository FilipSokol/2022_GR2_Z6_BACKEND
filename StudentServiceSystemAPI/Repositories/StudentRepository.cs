using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentServiceSystemAPI.Data;
using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;

namespace StudentServiceSystemAPI.Repositories
{
    public class StudentRepository : IStudentRepository
    {

        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly ILogger<DepartmentRepository> logger;

        public StudentRepository(ApplicationDbContext context, IMapper mapper, ILogger<DepartmentRepository> logger)
        {
            this.context = context;
            this.mapper = mapper;
            this.logger = logger;
        }

        public async Task<int> Create(int departmentId, int groupId, CreateStudentDto dto)
        {
            var student = this.mapper.Map<Student>(dto);

            var group = await this.context.Groups.FirstOrDefaultAsync(x => x.DepartmentId == departmentId && x.GroupId == groupId);

            if (group == null) throw new NullReferenceException("Group does not exist.");

            student.GroupId = groupId;

            await this.context.Students.AddAsync(student);
            await this.context.SaveChangesAsync();

            return student.StudentId;
        }

        public async Task Delete(int id)
        {
            var student = this.context
            .Students
                .FirstOrDefault(e => e.StudentId == id);

            if (student == null) throw new Exception("Student not found");

            this.context.Remove(student);
            await this.context.SaveChangesAsync();
        }

        public async Task<List<StudentDto>> GetAllByGroup(int departmentId, int groupId)
        {

            var group = await this.context
                .Groups
                .FirstOrDefaultAsync(x => x.GroupId == groupId && x.DepartmentId == departmentId);

            if (group is null) throw new NullReferenceException("Group does not exist");

            var students = await this.context
                 .Students
                 .Where(x => x.GroupId == group.GroupId)                 
                 .ToListAsync();

            var studentsDto = this.mapper.Map<List<StudentDto>>(students);

            return studentsDto;
        }
        public async Task<List<StudentDto>> GetAll()
        {

            var students = await this.context
                 .Students              
                 .ToListAsync();

            var studentsDto = this.mapper.Map<List<StudentDto>>(students);

            return studentsDto;
        }

        public async Task<Student> GetById(int id)
        {
            var student = await this.context
                .Students
                .FirstOrDefaultAsync(x => x.StudentId == id);

            if (student is null) throw new NullReferenceException("Student does not exist");

            return student;
        }

        public async Task Update(int id, UpdateStudentDto dto)
        {
            var student = await this.context
                .Students
                .FirstOrDefaultAsync(d => d.StudentId == id);

            if (student is null) throw new NullReferenceException("Student not found");

            student.FirstName = dto.FirstName;
            student.GroupId = dto.GroupId;
            student.LastName = dto.LastName;

            await this.context.SaveChangesAsync();
        }
    }
}
