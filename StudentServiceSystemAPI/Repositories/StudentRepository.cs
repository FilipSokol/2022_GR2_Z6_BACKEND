using StudentServiceSystemAPI.Models;

namespace StudentServiceSystemAPI.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public Task<int> Create(Student student)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Student>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, Student student)
        {
            throw new NotImplementedException();
        }
    }
}
