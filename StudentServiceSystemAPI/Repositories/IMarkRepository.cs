using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;

namespace StudentServiceSystemAPI.Repositories
{
    public interface IMarkRepository
    {
        Task<Mark> GetById(int id);
        Task<List<Mark>> GetAll();
        Task<int> Create(Mark mark);
        Task Delete(int id);
        Task Update(int id, Mark mark);
    }
}
