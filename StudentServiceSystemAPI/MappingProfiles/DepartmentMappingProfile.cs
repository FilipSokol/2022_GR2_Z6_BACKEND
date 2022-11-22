﻿using AutoMapper;
using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;

namespace StudentServiceSystemAPI.MappingProfiles
{
    public class DepartmentMappingProfile : Profile
    {
        public DepartmentMappingProfile()
        {
            CreateMap<Department, DepartmentDto>();
            CreateMap<CreateDepartmentDto, Department>();
            CreateMap<CreateGroupDto, Group>();
            CreateMap<CreateMarkDto, Mark>();
            CreateMap<CreateStudentDto, Student>();
            CreateMap<CreateSubjectDto, Subject>()
                .ForMember(x => x.Type, c => c.MapFrom(dto => dto.Type.ToString()));
            CreateMap<Subject, SubjectDto>()
                .ForMember(x => x.Type, c => c.MapFrom(dto => dto.Type.ToString()));
            CreateMap<CreateTeacherDto, Teacher>();
            CreateMap<Teacher, TeacherDto>();
        }
    }
}
