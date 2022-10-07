using StudentServiceSystemAPI.Models;

namespace StudentServiceSystemAPI.DtoModels
{
    public class DepartmentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public List<Group> Groups { get; set; }
    }
}
