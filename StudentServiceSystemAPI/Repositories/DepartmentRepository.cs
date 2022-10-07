using AutoMapper;
using StudentServiceSystemAPI.Data;
using StudentServiceSystemAPI.DtoModels;

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

        public Task<int> Create(DepartmentDto department)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<DepartmentDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<DepartmentDto> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, DepartmentDto department)
        {
            throw new NotImplementedException();
        }
    }
}
