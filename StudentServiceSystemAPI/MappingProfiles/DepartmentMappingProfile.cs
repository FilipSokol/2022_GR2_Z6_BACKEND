using AutoMapper;
using StudentServiceSystemAPI.Data;
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
            CreateMap<Schedule, ScheduleDto>();
            CreateMap<ScheduleDto, Schedule>();
            CreateMap<MarkDto, Mark>();
            CreateMap<Mark, MarkDto>();
            CreateMap<Student, StudentDto>();
            CreateMap<StudentDto, Student>();
            CreateMap<IGrouping<int, MarkDto>, GroupedMarkDto>()
                .ForMember(x => x.StudentId, c => c.MapFrom(dto => dto.Key))
                .ForMember(x => x.Marks, c => c.MapFrom(dto => dto.ToList()));

        }
    }
}
