using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentServiceSystemAPI.Data;
using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;
using System.Xml.Linq;

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

        public async Task<int> Create(int departmentId, CreateGroupDto dto)
        {
            var group = this.mapper.Map<Group>(dto);

            group.DepartmentId = departmentId;

            var previousGroup = this.context.Groups.Max(x => x.GroupId);

            var schedule = new Schedule()
            {
                GroupId = previousGroup + 1
            };

            await this.context.Schedules.AddAsync(schedule);
            await this.context.Groups.AddAsync(group);

            await this.context.SaveChangesAsync();

            return group.GroupId;
        }

        public async Task<List<Group>> GetAll(int departmentId)
        {
            var groups = await this.context
                 .Groups
                 .Where(x => x.DepartmentId == departmentId)
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

        public async Task Remove(int departmentId, int groupId)
        {
            var department = await GetDepartmentById(departmentId);

            var group = department
                .Groups
                .FirstOrDefault(e => e.GroupId == groupId);

            if (group == null) throw new Exception("Group not found");

            var schedule = await this.context.Schedules.FirstOrDefaultAsync(x => x.Id == group.GroupId);

            if (schedule == null) throw new Exception("schedule not found");

            this.context.Remove(group);
            this.context.Remove(schedule);
            await this.context.SaveChangesAsync();
        }

        public async Task RemoveAll(int departmentId)
        {
            var department = await GetDepartmentById(departmentId);

            this.context.RemoveRange(department.Groups);
            await this.context.SaveChangesAsync();
        }

        public async Task Update(int departmentId, int groupId, UpdateGroupDto dto)
        {
            var group = await this.context
            .Groups
            .FirstOrDefaultAsync(d => d.DepartmentId == departmentId && d.GroupId == groupId);

            if (group is null) throw new NullReferenceException("Group not found");

            group.Name = dto.Name;
            
            await this.context.SaveChangesAsync();
        }

        public async Task<List<SubjectsWithStudentsDto>> GetSubjectsWithStudentsWithMarks(int groupId)
        {
            var group = await this.context
                .Groups
                .Include(x => x.Schedule)
                .ThenInclude(x => x.Subjects)
                .ThenInclude(x => x.Marks)
                .ThenInclude(x => x.Student)
                .FirstOrDefaultAsync(x => x.GroupId == groupId);

            if (group is null) throw new NullReferenceException("Group does not exist.");

            var studentsList = await this.context
                .Students
                .Include(x => x.Marks)
                .Where(x => x.GroupId == group.GroupId)
                .ToListAsync();

           // var students = subjects.ToLookup(d => d.Name, x => mapper.Map<List<StudentWithMarksDto>>(x.Marks.Select(x => x.Student).Where(x => x.GroupId == groupId).Distinct().ToList()));
            var subjects = group.Schedule.Subjects.ToLookup(d => d.Name, x => studentsList).Distinct().ToList();
     

            var sub = new List<SubjectsWithStudentsDto>();

            foreach (var subject in subjects)
            {
                var subjectIds = await this.context
                    .Subjects
                    .Where(x => x.Name == subject.Key)
                    .Select(x => x.SubjectId)
                    .ToListAsync();

                if (subjectIds is null)
                {
                    throw new NullReferenceException("");
                }

                var students = subject.Distinct();

                foreach (var studentList in students)
                {
                    var studentss = studentList.DistinctBy(x => x.StudentId).ToList();

                    var studentsWithMarks = new List<StudentWithMarksDto>();
                    foreach (var student in studentList)
                    {
                        var marks = new List<MarkDto>();
                        if (student.Marks is not null)
                        {
                            foreach (var mark in student.Marks)
                            {
                                if (subjectIds.Contains((int)mark.SubjectId))
                                {
                                    marks.Add(mapper.Map<MarkDto>(mark));
                                }
                            }

                        }

                        var studentToAdd = (Student)student.Clone();

                        studentToAdd.Marks = mapper.Map<List<Mark>>(marks);

                        studentsWithMarks.Add(mapper.Map<StudentWithMarksDto>(studentToAdd));
                        
                    }

                    sub.Add(new SubjectsWithStudentsDto() { Name = subject.Key, SubjectId = subjectIds.FirstOrDefault(), Students = studentsWithMarks });
                    
                }
            }

            return sub;
        }

        private async Task<Department> GetDepartmentById(int departmentId)
        {
            var department = await this.context
                .Departments
                .Include(d => d.Groups)
                .FirstOrDefaultAsync(r => r.DepartmentId == departmentId);

            if (department is null)
                throw new Exception("Department not found");

            return department;
        }
    }
}
