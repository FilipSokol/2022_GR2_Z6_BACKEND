using Microsoft.AspNetCore.Mvc;
using StudentServiceSystemAPI.Models;
using StudentServiceSystemAPI.Repositories;

namespace StudentServiceSystemAPI.Controllers
{
    [Route("api/departments/{departmentId}/subjects")]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectRepository subjectRepository;

        public SubjectController(ISubjectRepository subjectRepository)
        {
            this.subjectRepository = subjectRepository;
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
