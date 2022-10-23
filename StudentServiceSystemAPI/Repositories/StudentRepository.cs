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

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Student>> GetAll(int departmentId, int groupId)
        {

            var group = await this.context
                .Groups
                .FirstOrDefaultAsync(x => x.GroupId == groupId && x.DepartmentId == departmentId);

            if (group is null) throw new NullReferenceException("Group does not exist");

            var students = await this.context
                 .Students
                 .Where(x => x.GroupId == group.GroupId)                 
                 .ToListAsync();

            return students;
        }

        public async Task<Student> GetById(int id)
        {
            var student = await this.context
                .Students
                .FirstOrDefaultAsync(x => x.StudentId == id);

            if (student is null) throw new NullReferenceException("Student does not exist");

            return student;
        }

        public Task Update(int id, Student student)
        {
            throw new NotImplementedException();
        }
    }
}
