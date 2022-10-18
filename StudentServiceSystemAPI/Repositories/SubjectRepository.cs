using StudentServiceSystemAPI.Models;

namespace StudentServiceSystemAPI.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        public Task<int> Create(Subject subject)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Subject>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Subject> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, Subject subject)
        {
            throw new NotImplementedException();
        }
    }
}
