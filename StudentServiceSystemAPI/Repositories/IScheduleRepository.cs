using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;

namespace StudentServiceSystemAPI.Repositories
{
    public interface IScheduleRepository
    {
        Task<Schedule> GetById(int id);
        Task<List<Subject>> GetPeriod(int groupId, GetPeriodDto period);
        Task<List<Schedule>> GetAll();
        Task<int> Create(ScheduleDto dto);
        Task Delete(int id);
        Task Update(int id, ScheduleDto dto);
    }
}
