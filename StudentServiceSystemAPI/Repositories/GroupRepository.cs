﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentServiceSystemAPI.Data;
using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;

namespace StudentServiceSystemAPI.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly ILogger<DepartmentRepository> logger;

        public GroupRepository(ApplicationDbContext context, IMapper mapper, ILogger<DepartmentRepository> logger)
        {
            this.context = context;
            this.mapper = mapper;
            this.logger = logger;
        }

        public Task<int> Create(int departmentId, Group group)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Group>> GetAll(int departmentId)
        {
            var groups = await this.context
                 .Groups
                 .ToListAsync();

            return groups;
        }

        public async Task<Group> GetById(int departmentId, int groupId)
        {
            var group = await this.context
                .Groups
                .FirstOrDefaultAsync(d => d.DepartmentId == departmentId && d.GroupId == groupId);

            if (group is null) throw new NullReferenceException("Group not found");

            return group;

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
