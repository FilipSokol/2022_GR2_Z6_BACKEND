namespace StudentServiceSystemAPI.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public int GroupId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<Mark> Marks { get; set; }

    }
}
