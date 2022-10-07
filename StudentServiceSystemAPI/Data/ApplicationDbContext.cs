using Microsoft.EntityFrameworkCore;
using StudentServiceSystemAPI.Models;

namespace StudentServiceSystemAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().Ignore(t => t.Groups);

            modelBuilder.Entity<Group>().HasOne(d => d.Department).WithMany(g => g.Groups).HasForeignKey(d => d.DepartmentId);

            modelBuilder.Entity<Group>().Ignore(t => t.Students);

            modelBuilder.Entity<Student>().HasOne(g => g.Group).WithMany(s => s.Students).HasForeignKey(g => g.GroupId);

            modelBuilder.Entity<Student>().Ignore(t => t.Marks);

            modelBuilder.Entity<Mark>().HasOne(s => s.Student).WithMany(m => m.Marks).HasForeignKey(s => s.StudentId);

            modelBuilder.Entity<Mark>().HasOne(s => s.Subject).WithMany(m => m.Marks).HasForeignKey(s => s.SubjectId);

            modelBuilder.Entity<Subject>().Ignore(t => t.Marks);

            Initialize(modelBuilder);
        }

        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                    new Department
                    {
                        DepartmentId = 1,
                        Name = "Department1",
                        Address = "Address1",
                        City = "City 1",
                        PostalCode = "PostalCode 1"

                    },
                     new Department
                     {
                         DepartmentId = 2,
                         Name = "Department2",
                         Address = "Address2",
                         City = "City 2",
                         PostalCode = "PostalCode 2"

                     },
                     new Department
                     {
                         DepartmentId = 3,
                         Name = "Department3",
                         Address = "Address3",
                         City = "City 3",
                         PostalCode = "PostalCode 3"

                     }
                );

            modelBuilder.Entity<Group>().HasData(
                    new Group
                    {
                        GroupId = 1,
                        Name = "Group 1",
                        DepartmentId = 1
                    },
                    new Group
                    {
                        GroupId = 2,
                        Name = "Group 2",
                        DepartmentId = 3
                    },
                    new Group
                    {
                        GroupId = 3,
                        Name = "Group 3",
                        DepartmentId = 2
                    }

                );

            modelBuilder.Entity<Student>().HasData(

                new Student
                {
                    StudentId = 1,
                    FirstName = "Jan",
                    LastName = "Kowalski",
                    GroupId = 1
                },
                new Student
                {
                    StudentId = 2,
                    FirstName = "Adam",
                    LastName = "Nowak",
                    GroupId = 2
                },
                new Student
                {
                    StudentId = 3,
                    FirstName = "Arek",
                    LastName = "Kedziora",
                    GroupId = 3
                }

                );


            modelBuilder.Entity<Subject>().HasData(

                new Subject
                {
                    SubjectId = 1,
                    Description = "Biology subject",
                    Name = "Biology"
                },
                new Subject
                {
                    SubjectId = 2,
                    Description = "Math subject",
                    Name = "Math"
                },
                new Subject
                {
                    SubjectId = 3,
                    Description = "Computer Science subject",
                    Name = "Computer Science"
                }

                );

            modelBuilder.Entity<Mark>().HasData(
                new Mark
                {
                    MarkId = 1,
                    StudentId = 1,
                    SubjectId = 1,
                    DateOfIssue = DateTime.Now,
                    MarkValue = 5,
                },
                new Mark
                {
                    MarkId = 2,
                    StudentId = 2,
                    SubjectId = 2,
                    DateOfIssue = DateTime.Now,
                    MarkValue = 4,
                },
                new Mark
                {
                    MarkId = 3,
                    StudentId = 1,
                    SubjectId = 2,
                    DateOfIssue = DateTime.Now,
                    MarkValue = 3,
                },
                new Mark
                {
                    MarkId = 4,
                    StudentId = 3,
                    SubjectId = 3,
                    DateOfIssue = DateTime.Now,
                    MarkValue = 4,
                }
                );
        }
    }


}

