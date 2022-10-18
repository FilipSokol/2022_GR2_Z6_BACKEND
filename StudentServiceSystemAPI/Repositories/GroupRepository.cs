using StudentServiceSystemAPI.Models;

namespace StudentServiceSystemAPI.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        public Task<int> Create(int departmentId, Group group)
        {
            throw new NotImplementedException();
        }

        public Task<List<Group>> GetAll(int departmentId)
        {
            throw new NotImplementedException();
        }

        public Task<Group> GetById(int departmentId, int groupId)
        {
            throw new NotImplementedException();
        }

        public Task Remove(int departmentId, int groupId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAll(int departmentId)
        {
            throw new NotImplementedException();
        }

        public Task Update(int departmentId, int groupId, Group group)
        {
            throw new NotImplementedException();
        }
    }
}
