using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;

namespace StudentServiceSystemAPI.Repositories
{
    public interface ITeacherRepository
    {
        Task<Teacher> GetById(int id);
        Task<List<Teacher>> GetAll();
        Task<List<Teacher>> GetByDepartmentId(int departmentId);
        Task<int> Create(int departmentId, CreateTeacherDto teacher);
        Task Delete(int id);
        Task Update(int id, UpdateTeacherDto teacher);
        Task AssignSubject(int teacherId, int subjectId);
        Task UnassignSubject(int teacherId, int subjectId);
        Task<List<int>> GetAllTeacherGroups(int teacherId);

    }
}
