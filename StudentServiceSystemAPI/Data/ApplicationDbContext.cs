using Microsoft.EntityFrameworkCore;
using StudentServiceSystemAPI.Entities;
using StudentServiceSystemAPI.Models;
using System.Runtime.CompilerServices;

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
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Group>()
                .HasOne(s => s.Schedule)
                .WithOne(g => g.Group)
                .HasForeignKey<Schedule>(s => s.GroupId);

            Initialize(modelBuilder);

        }

        public static void Initialize(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Department>().HasData(
                    new Department
                    {
                        DepartmentId = 1,
                        Name = "Wydział Inżynierii Mechanicznej i Informatyki",
                        Address = "Dąbrowskiego 64",
                        City = "Częstochowa",
                        PostalCode = "00-000"

                    },
                     new Department
                     {
                         DepartmentId = 2,
                         Name = "Wydział Zarządzania",
                         Address = "Armii Krajowej 2",
                         City = "Częstochowa",
                         PostalCode = "00-000"

                     },
                     new Department
                     {
                         DepartmentId = 3,
                         Name = "Wydział Elektryczny",
                         Address = "Armii Krajowej 14",
                         City = "Częstochowa",
                         PostalCode = "00-000"

                     }
                );

            modelBuilder.Entity<Group>().HasData(
                    new Group
                    {
                        GroupId = 1,
                        Name = "Grupa 1",
                        DepartmentId = 1
                    },
                    new Group
                    {
                        GroupId = 2,
                        Name = "Grupa 2",
                        DepartmentId = 3
                    },
                    new Group
                    {
                        GroupId = 3,
                        Name = "Grupa 3",
                        DepartmentId = 2
                    }

                );

            modelBuilder.Entity<Schedule>().HasData(
               new Schedule
               {
                   Id = 1,
                   GroupId = 1,
               },
               new Schedule
               {
                   Id = 2,
                   GroupId = 2,
               },
               new Schedule
               {
                   Id = 3,
                   GroupId = 3,
               }
               );

            modelBuilder.Entity<Student>().HasData(

                new Student
                {
                    StudentId = 1,
                    FirstName = "Jan",
                    LastName = "Kowalski",
                    Email = "jan@kowalski.com",
                    GroupId = 1
                },
                new Student
                {
                    StudentId = 2,
                    FirstName = "Adam",
                    LastName = "Nowak",
                    Email = "adam@nowak.com",
                    GroupId = 2
                },
                new Student
                {
                    StudentId = 3,
                    FirstName = "Arek",
                    LastName = "Kedziora",
                    Email = "arek@kedziora.com",
                    GroupId = 3
                });

           
            modelBuilder.Entity<Subject>().HasData(

                new Subject
                {
                    SubjectId = 1,
                    Description = "Biology subject",
                    Name = "Biology",
                    ScheduleId = 1,
                    StartTime = DateTime.UtcNow,
                    EndTime = DateTime.UtcNow,
                    TeacherId = 1
                    
                },
                new Subject
                {
                    SubjectId = 2,
                    Description = "Math subject",
                    Name = "Math",
                    ScheduleId = 1,
                    StartTime = DateTime.UtcNow,
                    EndTime = DateTime.UtcNow,
                    TeacherId = 2
                },
                new Subject
                {
                    SubjectId = 3,
                    Description = "Computer Science subject",
                    Name = "Computer Science",
                    StartTime = DateTime.UtcNow,
                    ScheduleId = 1,
                    EndTime = DateTime.UtcNow,
                    TeacherId = 3
                },
                new Subject
                {
                    SubjectId = 4,
                    Description = "Computer Science subject",
                    Name = "Computer Science",
                    StartTime = DateTime.UtcNow.AddHours(1),
                    ScheduleId = 1,
                    EndTime = DateTime.UtcNow.AddHours(2),
                    TeacherId = 3
                },
                 new Subject
                {
                    SubjectId = 5,
                    Description = "Computer Science subject",
                    Name = "Computer Science",
                    StartTime = DateTime.UtcNow,
                    ScheduleId = 1,
                    EndTime = DateTime.UtcNow,
                    TeacherId = 3
                },
                 new Subject
                {
                    SubjectId = 6,
                    Description = "Computer Science subject",
                    Name = "Computer Science",
                    StartTime = DateTime.UtcNow,
                    ScheduleId = 1,
                    EndTime = DateTime.UtcNow,
                    TeacherId = 3
                },
                 new Subject
                {
                    SubjectId = 7,
                    Description = "Computer Science subject",
                    Name = "Computer Science",
                    StartTime = DateTime.UtcNow,
                    ScheduleId = 1,
                    EndTime = DateTime.UtcNow,
                    TeacherId = 3
                },
                 new Subject
                {
                    SubjectId = 8,
                    Description = "Computer Science subject",
                    Name = "Computer Science",
                    StartTime = DateTime.UtcNow,
                    ScheduleId = 1,
                    EndTime = DateTime.UtcNow,
                    TeacherId = 3
                },
                 new Subject
                {
                    SubjectId = 9,
                    Description = "Computer Science subject",
                    Name = "Computer Science",
                    StartTime = DateTime.UtcNow,
                    ScheduleId = 1,
                    EndTime = DateTime.UtcNow,
                    TeacherId = 3
                },
                 new Subject
                {
                    SubjectId = 10,
                    Description = "Computer Science subject",
                    Name = "Computer Science",
                    StartTime = DateTime.UtcNow,
                    ScheduleId = 1,
                    EndTime = DateTime.UtcNow,
                    TeacherId = 3
                }

                );

            modelBuilder.Entity<Teacher>().HasData(
                new Teacher
                {
                    TeacherId = 1,
                    FirstName = "Jan",
                    LastName = "Kowalski",
                    Email = "kowalski@teacher.com",
                    DepartmentId = 1
                },
                 new Teacher
                 {
                     TeacherId = 2,
                     FirstName = "Adam",
                     LastName = "Nowak",
                     Email = "nowak@teacher.com",
                     DepartmentId = 1
                 },
                 new Teacher
                 {
                     TeacherId = 3,
                     FirstName = "Michał",
                     LastName = "Monitor",
                     Email = "monitor@teacher.com",
                     DepartmentId = 1
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
                    Description = "desc"
                },
                new Mark
                {
                    MarkId = 2,
                    StudentId = 2,
                    SubjectId = 2,
                    DateOfIssue = DateTime.Now,
                    MarkValue = 4,
                    Description = "desc"
                },
                new Mark
                {
                    MarkId = 3,
                    StudentId = 1,
                    SubjectId = 2,
                    DateOfIssue = DateTime.Now,
                    MarkValue = 3,
                    Description = "desc"
                },
                new Mark
                {
                    MarkId = 4,
                    StudentId = 3,
                    SubjectId = 3,
                    DateOfIssue = DateTime.Now,
                    MarkValue = 4,
                    Description = "desc"
                }
                );
        }
    }


}

