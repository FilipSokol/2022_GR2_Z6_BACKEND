using StudentServiceSystemAPI.Models;

namespace StudentServiceSystemAPI.Repositories
{
    public interface ISubjectRepository
    {
        Task<Subject> GetById(int id);
        Task<List<Subject>> GetAll();
        Task<int> Create(Subject subject);
        Task Delete(int id);
        Task Update(int id, Subject subject);
    }
}
