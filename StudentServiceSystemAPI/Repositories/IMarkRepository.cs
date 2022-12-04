using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;

namespace StudentServiceSystemAPI.Repositories
{
    public interface IMarkRepository
    {
        Task<Mark> GetById(int studentId, int id);
        Task<List<Mark>> GetAll(int studentId);
        Task<int> Create(int studentId, CreateMarkDto dto);
        Task Delete(int id);
        Task Update(int id, UpdateMarkDto mark);
        Task<List<MarkDto>> GetBySubjectName(int studentId, string subjectName);
        Task<List<GroupedMarkDto>> GetByTeacherIdAndSubjectName(int teacherId, string subjectName);
    }
}
