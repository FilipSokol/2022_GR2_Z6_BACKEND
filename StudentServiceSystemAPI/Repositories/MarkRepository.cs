using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentServiceSystemAPI.Data;
using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;
using System.Text.RegularExpressions;

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

        public async Task Delete(int id)
        {
            var mark = await this.context
                .Marks
                .FirstOrDefaultAsync(e => e.MarkId == id);

            if (mark == null) throw new Exception("Mark not found");

            this.context.Remove(mark);
            await this.context.SaveChangesAsync();
        }

        public async Task<List<MarkDto>> GetAll(int studentId)
        {
            var marks = await this.context
                .Marks
                .Where(x => x.StudentId == studentId)
                .ToListAsync();

            if (marks == null) throw new NullReferenceException("Student does not have any marks");

            var marksDto = mapper.Map<List<MarkDto>>(marks);

            return marksDto;
        }

        public async Task<MarkDto> GetById(int studentId, int id)
        {
            var mark = await this.context
                 .Marks
                 .FirstOrDefaultAsync(x => x.MarkId == id && x.StudentId == studentId);

            if (mark == null) throw new NullReferenceException("Mark does not exist.");

            var markDto = mapper.Map<MarkDto>(mark);

            return markDto;
        }

        public async Task Update(int id, UpdateMarkDto dto)
        {
            var mark = await this.context
                .Marks
                .FirstOrDefaultAsync(d => d.MarkId == id);

            if (mark is null) throw new NullReferenceException("Mark not found");

            mark.DateOfIssue = dto.DateOfIssue;
            mark.Description = dto.Description;
            mark.MarkValue = dto.MarkValue;

            await this.context.SaveChangesAsync();
        }

        public async Task<List<MarkDto>> GetBySubjectName(int studentId, string name)
        {
            var marks = await this.context
                .Marks
                .Where(x => x.Subject.Name == name && x.StudentId == studentId)
                .ToListAsync();

            if (marks == null) throw new NullReferenceException($"Subject {name} does not contain any marks");

            var marksDto = mapper.Map<List<MarkDto>>(marks);

            return marksDto;
        }

        public async Task<List<GroupedMarkDto>> GetByTeacherIdAndSubjectName(int teacherId, string subjectName)
        {
            var teacher = await this.context
                .Teachers
                .Include(x => x.Subjects)
                .ThenInclude(x => x.Marks)
                .Where(x => x.Subjects.Any(x => x.Name == subjectName))
                .FirstOrDefaultAsync(x => x.TeacherId == teacherId);

            if (teacher == null) throw new NullReferenceException("teacher not found");

            var subjectMarks = new List<MarkDto>();

            foreach (var subject in teacher.Subjects)
            {
                subjectMarks.AddRange(mapper.Map<List<MarkDto>>(subject.Marks));
            }

            var groupedMarks = subjectMarks.GroupBy(x => x.StudentId).ToList();

            var groupedMarksDto = mapper.Map<List<GroupedMarkDto>>(groupedMarks);

            return groupedMarksDto;

        }
    }
}
