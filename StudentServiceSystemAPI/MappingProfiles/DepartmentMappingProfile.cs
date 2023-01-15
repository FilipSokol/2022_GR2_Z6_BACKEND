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
            CreateMap<IGrouping<string, Mark>, SubjectWithMarksDto>()
                .ForMember(x => x.Name, c => c.MapFrom(dto => dto.Key))
                .ForMember(x => x.Marks, c => c.MapFrom(dto => dto.Select(x => x.MarkValue).ToList()));
            CreateMap<ILookup<string, List<StudentWithMarksDto>>, SubjectsWithStudentsDto>()
                .ForMember(x => x.Name, c => c.MapFrom(dto => dto.Select(x => x.Key)))
                .ForMember(x => x.Students, c => c.MapFrom(dto => dto.ToList()));

            CreateMap<Student, StudentWithMarksDto>()
                .ForMember(x => x.Marks, c => c.MapFrom(dto => dto.Marks));

            CreateMap<ILookup<string, List<StudentWithMarksDto>>, SubjectsWithStudentsDto>()
                .ForMember(x => x.Name, c => c.MapFrom(dto => dto.Select(x => x.Key)))
                .ForMember(x => x.Students, c => c.MapFrom(dto => dto.ToList()));

            CreateMap<Subject, SubjectWithMarksDto>()
                .ForMember(x => x.Name, c => c.MapFrom(x => x.Name))
                .ForMember(x => x.Marks, c => c.MapFrom(dto => new List<int>()));

        }
    }
}
