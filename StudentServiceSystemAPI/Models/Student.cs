namespace StudentServiceSystemAPI.Models
{
    public class Student : ICloneable
    {
        public int StudentId { get; set; }
        public int GroupId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<Mark> Marks { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
}
