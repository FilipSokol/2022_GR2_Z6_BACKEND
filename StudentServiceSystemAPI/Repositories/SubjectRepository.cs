using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentServiceSystemAPI.Data;
using StudentServiceSystemAPI.DtoModels;
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
        public async Task<int> Create(CreateSubjectDto dto)
        {
            var subject = this.mapper.Map<Subject>(dto);

            await this.context.Subjects.AddAsync(subject);
            await this.context.SaveChangesAsync();

            return subject.SubjectId;
        }

        public async Task Delete(int id)
        {
            var subject = this.context
                .Subjects
                .FirstOrDefault(e => e.SubjectId == id);

            if (subject == null) throw new Exception("Subject not found");

            this.context.Remove(subject);
            await this.context.SaveChangesAsync();
        }

        public async Task<List<Subject>> GetAll()
        {
            var subjects = await this.context
                .Subjects
                .ToListAsync();

            if (subjects == null) throw new NullReferenceException("Subjects does not exist");

            return subjects;
        }

        public async Task<List<SubjectWithMarksDto>> GetAllWithMarksByStudentId(int studentId)
        {
            var student = await this.context
                .Students
                .Include(x => x.Marks)
                .ThenInclude(x => x.Subject)
                .FirstOrDefaultAsync(x => x.StudentId == studentId);


            var marks = student.Marks.GroupBy(x => x.Subject.Name).ToList();

            var marksValues = mapper.Map<List<SubjectWithMarksDto>>(marks);
            
            return marksValues;
        }

        public async Task<Subject> GetById(int id)
        {
            var subject = await this.context
                .Subjects
                .FirstOrDefaultAsync(x => x.SubjectId == id);

            if (subject == null) throw new NullReferenceException("Subject does not exist");

            return subject;
        }

        public async Task Update(int id, SubjectDto dto)
        {
            var subject = await this.context
                 .Subjects
                 .FirstOrDefaultAsync(d => d.SubjectId == id);

            if (subject is null) throw new NullReferenceException("Subject not found");

            //if (Enum.GetValues<SubjectType>().ToList().Contains(Enum.TryParse<SubjectType>(dto.Type)))
            //{

            //}

            subject.Name = dto.Name;
            subject.Description = dto.Description;
            subject.StartTime = dto.StartTime;
            subject.EndTime = dto.EndTime;
            subject.ECTS = dto.ECTS;
            subject.ScheduleId = dto.ScheduleId;
            subject.Type = (SubjectType)Enum.Parse(typeof(SubjectType), dto.Type); 
            subject.TeacherId = dto.TeacherId;
            await this.context.SaveChangesAsync();
        }
    }
}
