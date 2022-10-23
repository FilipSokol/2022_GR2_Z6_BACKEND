using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentServiceSystemAPI.Data;
using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;

namespace StudentServiceSystemAPI.Repositories
{
    public class MarkRepository : IMarkRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly ILogger<DepartmentRepository> logger;

        public MarkRepository(ApplicationDbContext context, IMapper mapper, ILogger<DepartmentRepository> logger)
        {
            this.context = context;
            this.mapper = mapper;
            this.logger = logger;
        }

        public async Task<int> Create(int studentId, CreateMarkDto dto)
        {
            var mark = this.mapper.Map<Mark>(dto);
            mark.StudentId = studentId;
            
            await this.context.Marks.AddAsync(mark);
            await this.context.SaveChangesAsync();

            return mark.MarkId;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Mark>> GetAll(int studentId)
        {
            var marks = await this.context
                .Marks
                .Where(x => x.StudentId == studentId)
                .ToListAsync();

            if (marks == null) throw new NullReferenceException("Student does not have any marks");

            return marks;
        }

        public async Task<Mark> GetById(int studentId, int id)
        {
            var mark = await this.context
                 .Marks
                 .FirstOrDefaultAsync(x => x.MarkId == id && x.StudentId == studentId);

            if (mark == null) throw new NullReferenceException("Mark does not exist.");

            return mark;
        }

        public Task Update(int id, Mark mark)
        {
            throw new NotImplementedException();
        }
    }
}
