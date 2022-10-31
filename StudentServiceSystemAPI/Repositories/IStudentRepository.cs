using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;

namespace StudentServiceSystemAPI.Repositories
{
    public interface IStudentRepository
    {
        Task<Student> GetById(int id);
        Task<List<Student>> GetAll(int departmentId, int groupId);
        Task<int> Create(int departmentId, int groupId, CreateStudentDto student);
        Task Delete(int id);
        Task Update(int id, UpdateStudentDto student);
    }
}
