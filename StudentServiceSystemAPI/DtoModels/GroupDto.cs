using StudentServiceSystemAPI.Models;

namespace StudentServiceSystemAPI.DtoModels
{
    public class GroupDto
    {
        public int GroupId { get; set; }
        public string? Name { get; set; }
        public int DepartmentId { get; set; }
        public Schedule Schedule { get; set; }
    }
}
