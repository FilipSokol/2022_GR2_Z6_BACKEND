using Microsoft.AspNetCore.Mvc;
using StudentServiceSystemAPI.Models;
using StudentServiceSystemAPI.Repositories;

namespace StudentServiceSystemAPI.Controllers
{
    [ApiController]
    [Route("api/departments/{departmentId}/groups/{groupId}/students")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        [HttpGet("/api/students/{id}")]
        public async Task<ActionResult<Student>> GetById([FromRoute] int id)
        {
            var student = await studentRepository.GetById(id);
            return Ok(student);
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAll([FromRoute] int departmentId, [FromRoute] int groupId)
        {
            var students = await this.studentRepository.GetAll(departmentId, groupId);
            return Ok(students);
        }
        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] Student student)
        {
            throw new NotImplementedException();
        }
        [HttpDelete]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            throw new NotImplementedException();
        }
        [HttpPut]
        public async Task<ActionResult> Update([FromRoute]int id, [FromBody] Student student)
        {
            throw new NotImplementedException();
        }
    }
}
