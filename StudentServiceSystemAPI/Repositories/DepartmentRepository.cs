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

        public async  Task Delete(int id)
        {
            var department = await this.context
                .Departments
                .FirstOrDefaultAsync(e => e.DepartmentId == id);

            if (department == null) throw new Exception("Department not found");

            this.context.Remove(department);
            await this.context.SaveChangesAsync();
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

        public async Task Update(int id, UpdateDepartmentDto dto)
        {
            var department = await this.context
                .Departments
                .FirstOrDefaultAsync(d => d.DepartmentId == id);

            if (department is null) throw new NullReferenceException("Department not found");

            department.Name = dto.Name;
            department.Address = dto.Address;
            department.City = dto.City;
            department.PostalCode = dto.PostalCode;

            this.logger.LogInformation($"Department with id: {id} UPDATE action invoked. Updated data: '{department.Name}' to '{dto.Name}', '{department.Address}' to '{dto.Address}'");

            await this.context.SaveChangesAsync();
        }
    }
}
