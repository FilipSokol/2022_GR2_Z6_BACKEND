using Microsoft.AspNetCore.Mvc;
using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Repositories;

namespace StudentServiceSystemAPI.Controllers
{
    [Route("api/departments")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DepartmentDto>> Get([FromRoute]int id)
        {
            var department = await this.departmentRepository.GetById(id);
            return Ok(department);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DepartmentDto>>> Get()
        {
            var departments = await this.departmentRepository.GetAll();
            return Ok(departments);
        }

        [HttpPost]
        public async Task<ActionResult> CreateDepartment([FromBody] CreateDepartmentDto dto)
        {
            var id = await this.departmentRepository.Create(dto);
            return Created($"/api/department/{id}", null);
        }


        [HttpPut]
        public async Task<ActionResult> Update([FromBody] DepartmentDto dto, [FromRoute] int id)
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete([FromRoute]int id)
        {
            return NoContent();
        }


    }
}
