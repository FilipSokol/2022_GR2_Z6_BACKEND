namespace StudentServiceSystemAPI.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public virtual List<Group> Groups { get; set; }
        public virtual List<Teacher> Teachers { get; set; }
    }
}
