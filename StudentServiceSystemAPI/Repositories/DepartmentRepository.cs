using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentServiceSystemAPI.Data;
using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;

namespace StudentServiceSystemAPI.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly ILogger<DepartmentRepository> logger;

        public DepartmentRepository(ApplicationDbContext context, IMapper mapper, ILogger<DepartmentRepository> logger)
        {
            this.context = context;
            this.mapper = mapper;
            this.logger = logger;
        }

        public async Task<int> Create(CreateDepartmentDto dto)
        {
            var department = this.mapper.Map<Department>(dto);

            await this.context.Departments.AddAsync(department);
            await this.context.SaveChangesAsync();

            return department.DepartmentId;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<DepartmentDto>> GetAll()
        {
            var departments = await this.context
                .Departments
                .ToListAsync();

            var departmentsDtos = this.mapper.Map<List<DepartmentDto>>(departments);

            return departmentsDtos;
        }

        public async Task<DepartmentDto> GetById(int id)
        {
            var department = await this.context
                .Departments
                .FirstOrDefaultAsync(d => d.DepartmentId == id);

            if (department is null) throw new NullReferenceException("Department not found");

            var result = this.mapper.Map<DepartmentDto>(department);
            return result;
        }

        public Task Update(int id, DepartmentDto department)
        {
            throw new NotImplementedException();
        }
    }
}
