using StudentServiceSystemAPI.DtoModels;

namespace StudentServiceSystemAPI.Repositories
{
    public interface IDepartmentRepository
    {
        Task<DepartmentDto> GetById(int id);
        Task<List<DepartmentDto>> GetAll();
        Task<int> Create(CreateDepartmentDto department);
        Task Delete(int id);
        Task Update(int id, DepartmentDto department);
    }
}
