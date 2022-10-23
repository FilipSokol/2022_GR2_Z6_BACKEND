namespace StudentServiceSystemAPI.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string? Name { get; set; }
        public int DepartmentId { get; set; }

        public virtual Schedule Schedule { get; set; }

        public List<Student> Students { get; set; }

    }
}
