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

        public async Task<ActionResult<Student>> GetById(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<ActionResult<List<Student>>> GetAll()
        {
            throw new NotImplementedException();
        }
        public async Task<ActionResult<int>> Create(Student student)
        {
            throw new NotImplementedException();
        }
        public async Task<ActionResult> Delete(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<ActionResult> Update(int id, Student student)
        {
            throw new NotImplementedException();
        }
    }
}
