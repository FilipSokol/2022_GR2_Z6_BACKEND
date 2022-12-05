using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;

namespace StudentServiceSystemAPI.Repositories
{
    public interface ISubjectRepository
    {
        Task<Subject> GetById(int id);
        Task<List<Subject>> GetAll();
        Task<int> Create(CreateSubjectDto dto);
        Task Delete(int id);
        Task Update(int id, SubjectDto subject);
        Task<List<SubjectWithMarksDto>> GetAllWithMarksByStudentId(int studentId);
    }
}
