using Microsoft.AspNetCore.Mvc;
using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Repositories;
using Swashbuckle.AspNetCore.Annotations;

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
        [SwaggerOperation(Summary = "Get department by Id.")]
        public async Task<ActionResult<DepartmentDto>> Get([FromRoute]int id)
        {
            var department = await this.departmentRepository.GetById(id);
            return Ok(department);
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Get all departments.")]
        public async Task<ActionResult<IEnumerable<DepartmentDto>>> Get()
        {
            var departments = await this.departmentRepository.GetAll();
            return Ok(departments);
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Create department")]
        public async Task<ActionResult> CreateDepartment([FromBody] CreateDepartmentDto dto)
        {
            var id = await this.departmentRepository.Create(dto);
            return Created($"/api/department/{id}", null);
        }

        [HttpPut("{id}")]
        [SwaggerOperation(Summary = "Edit department")]
        public async Task<ActionResult> Update([FromBody] UpdateDepartmentDto dto, [FromRoute] int id)
        {
            await this.departmentRepository.Update(id, dto);

            return Ok();
        }

        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "Delete department by Id")]
        public async Task<ActionResult> Delete([FromRoute]int id)
        {
            await this.departmentRepository.Delete(id);
            return NoContent();
        }


    }
}
