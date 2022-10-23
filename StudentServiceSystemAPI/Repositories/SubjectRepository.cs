using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentServiceSystemAPI.Data;
using StudentServiceSystemAPI.Models;

namespace StudentServiceSystemAPI.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {

        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly ILogger<DepartmentRepository> logger;

        public SubjectRepository(ApplicationDbContext context, IMapper mapper, ILogger<DepartmentRepository> logger)
        {
            this.context = context;
            this.mapper = mapper;
            this.logger = logger;
        }
        public Task<int> Create(Subject subject)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Subject>> GetAll()
        {
            var subjects = await this.context
                .Subjects
                .ToListAsync();

            if (subjects == null) throw new NullReferenceException("Subjects does not exist");

            return subjects;
        }

        public async Task<Subject> GetById(int id)
        {
            var subject = await this.context
                .Subjects
                .FirstOrDefaultAsync(x => x.SubjectId == id);

            if (subject == null) throw new NullReferenceException("Subject does not exist");

            return subject;
        }

        public Task Update(int id, Subject subject)
        {
            throw new NotImplementedException();
        }
    }
}
