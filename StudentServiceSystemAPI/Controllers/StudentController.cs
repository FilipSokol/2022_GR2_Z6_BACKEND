using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;
using StudentServiceSystemAPI.Repositories;
using Swashbuckle.AspNetCore.Annotations;
using System.Text.RegularExpressions;

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
        [SwaggerOperation(Summary = "Get student by id")]
        public async Task<ActionResult<Student>> GetById([FromRoute] int id)
        {
            var student = await studentRepository.GetById(id);
            return Ok(student);
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Get all students by group")]
        public async Task<ActionResult<List<Student>>> GetAllByGroup([FromRoute] int departmentId, [FromRoute] int groupId)
        {
            var students = await this.studentRepository.GetAllByGroup(departmentId, groupId);
            return Ok(students);
        }

        [HttpGet]
        [Route("/api/students")]
        [SwaggerOperation(Summary = "Get all students")]
        public async Task<ActionResult<List<StudentDto>>> GetAll()
        {
            var students = await this.studentRepository.GetAll();

            return Ok(students);
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Create Student")]
        public async Task<ActionResult<int>> Create([FromRoute] int departmentId, [FromRoute] int groupId, [FromBody] CreateStudentDto dto)
        {
            var id = await this.studentRepository.Create(departmentId, groupId, dto);
            return Created($"/api/department/{id}", null);
        }
        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "Delete student")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            await this.studentRepository.Delete(id);
            return NoContent();
        }
        [HttpPut("{id}")]
        [SwaggerOperation(Summary = "Update student")]
        public async Task<ActionResult> Update([FromRoute]int id, [FromBody] UpdateStudentDto student)
        {
            await this.studentRepository.Update(id, student);
            return Ok();
        }
    }
}
