using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentServiceSystemAPI.Data;
using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;

namespace StudentServiceSystemAPI.Repositories
{
    public class ScheduleRepository : IScheduleRepository
    {

        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly ILogger<DepartmentRepository> logger;

        public ScheduleRepository(ApplicationDbContext context, IMapper mapper, ILogger<DepartmentRepository> logger)
        {
            this.context = context;
            this.mapper = mapper;
            this.logger = logger;
        }
        public async Task<int> Create(ScheduleDto dto)
        {
            var schedule = this.mapper.Map<Schedule>(dto);

            await this.context.Schedules.AddAsync(schedule);
            await this.context.SaveChangesAsync();

            return schedule.Id;
        }

        public async Task Delete(int id)
        {
            var schedule = this.context
                .Schedules
                .FirstOrDefault(e => e.Id == id);

            if (schedule == null) throw new Exception("schedule not found");

            this.context.Remove(schedule);
            await this.context.SaveChangesAsync();
        }

        public async Task<List<Schedule>> GetAll()
        {
            var schedule = await this.context
                .Schedules
                .ToListAsync();

            if (schedule == null) throw new NullReferenceException("schedule does not exist");

            return schedule;
        }

        public async Task<Schedule> GetById(int groupId)
        {
            var schedule = await this.context
                .Schedules
                .Include(x => x.Subjects)
                .FirstOrDefaultAsync(x => x.GroupId == groupId);

            if (schedule == null) throw new NullReferenceException("schedule does not exist");

            return schedule;
        }

        public async Task<List<Subject>> GetPeriod(int groupId, GetPeriodDto period)
        {
            var schedule = await this.context
                .Schedules
                .Include(x => x.Subjects)
                .FirstOrDefaultAsync(x => x.GroupId == groupId);

            var subjectsInPeriod = schedule.Subjects.Where(x => x.StartTime >= period.startDate && x.EndTime <= period.endDate).ToList();

            return subjectsInPeriod;
                
        }

        public async Task Update(int id, ScheduleDto dto)
        {
            var schedule = await this.context
                 .Schedules
                 .FirstOrDefaultAsync(d => d.Id == id);

            if (schedule is null) throw new NullReferenceException("schedule not found");

            //if (Enum.GetValues<SubjectType>().ToList().Contains(Enum.TryParse<SubjectType>(dto.Type)))
            //{

            //}

            schedule.GroupId = dto.GroupId;
            await this.context.SaveChangesAsync();
        }
    }
}
