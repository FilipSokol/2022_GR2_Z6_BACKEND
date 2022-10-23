using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;

namespace StudentServiceSystemAPI.Repositories
{
    public interface IMarkRepository
    {
        Task<Mark> GetById(int studentId, int id);
        Task<List<Mark>> GetAll(int studentId);
        Task<int> Create(Mark mark);
        Task Delete(int id);
        Task Update(int id, Mark mark);
    }
}
