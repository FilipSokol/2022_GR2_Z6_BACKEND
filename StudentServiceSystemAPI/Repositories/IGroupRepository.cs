﻿using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;

namespace StudentServiceSystemAPI.Repositories
{
    public interface IGroupRepository
    {
        Task<Group> GetById(int departmentId, int groupId);
        Task<List<Group>> GetAll(int departmentId);
        Task<int> Create(int departmentId, CreateGroupDto group);
        Task RemoveAll(int departmentId);
        Task Remove(int departmentId, int groupId);
        Task Update(int departmentId, int groupId, UpdateGroupDto group);

    }
}
