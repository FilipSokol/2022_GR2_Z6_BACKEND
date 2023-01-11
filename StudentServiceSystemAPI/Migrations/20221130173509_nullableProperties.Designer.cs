﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentServiceSystemAPI.Data;

#nullable disable

namespace StudentServiceSystemAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221130173509_nullableProperties")]
    partial class nullableProperties
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StudentServiceSystemAPI.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("StudentServiceSystemAPI.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            Address = "Address1",
                            City = "City 1",
                            Name = "Department1",
                            PostalCode = "PostalCode 1"
                        },
                        new
                        {
                            DepartmentId = 2,
                            Address = "Address2",
                            City = "City 2",
                            Name = "Department2",
                            PostalCode = "PostalCode 2"
                        },
                        new
                        {
                            DepartmentId = 3,
                            Address = "Address3",
                            City = "City 3",
                            Name = "Department3",
                            PostalCode = "PostalCode 3"
                        });
                });

            modelBuilder.Entity("StudentServiceSystemAPI.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupId"), 1L, 1);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            GroupId = 1,
                            DepartmentId = 1,
                            Name = "Group 1"
                        },
                        new
                        {
                            GroupId = 2,
                            DepartmentId = 3,
                            Name = "Group 2"
                        },
                        new
                        {
                            GroupId = 3,
                            DepartmentId = 2,
                            Name = "Group 3"
                        });
                });

            modelBuilder.Entity("StudentServiceSystemAPI.Models.Mark", b =>
                {
                    b.Property<int>("MarkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MarkId"), 1L, 1);

                    b.Property<DateTime>("DateOfIssue")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MarkValue")
                        .HasColumnType("float");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("MarkId");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Marks");

                    b.HasData(
                        new
                        {
                            MarkId = 1,
                            DateOfIssue = new DateTime(2022, 11, 30, 18, 35, 8, 816, DateTimeKind.Local).AddTicks(275),
                            Description = "desc",
                            MarkValue = 5.0,
                            StudentId = 1,
                            SubjectId = 1
                        },
                        new
                        {
                            MarkId = 2,
                            DateOfIssue = new DateTime(2022, 11, 30, 18, 35, 8, 816, DateTimeKind.Local).AddTicks(309),
                            Description = "desc",
                            MarkValue = 4.0,
                            StudentId = 2,
                            SubjectId = 2
                        },
                        new
                        {
                            MarkId = 3,
                            DateOfIssue = new DateTime(2022, 11, 30, 18, 35, 8, 816, DateTimeKind.Local).AddTicks(311),
                            Description = "desc",
                            MarkValue = 3.0,
                            StudentId = 1,
                            SubjectId = 2
                        },
                        new
                        {
                            MarkId = 4,
                            DateOfIssue = new DateTime(2022, 11, 30, 18, 35, 8, 816, DateTimeKind.Local).AddTicks(313),
                            Description = "desc",
                            MarkValue = 4.0,
                            StudentId = 3,
                            SubjectId = 3
                        });
                });

            modelBuilder.Entity("StudentServiceSystemAPI.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId")
                        .IsUnique();

                    b.ToTable("Schedules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GroupId = 1
                        },
                        new
                        {
                            Id = 2,
                            GroupId = 2
                        },
                        new
                        {
                            Id = 3,
                            GroupId = 3
                        });
                });

            modelBuilder.Entity("StudentServiceSystemAPI.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.HasIndex("GroupId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            Email = "jan@kowalski.com",
                            FirstName = "Jan",
                            GroupId = 1,
                            LastName = "Kowalski"
                        },
                        new
                        {
                            StudentId = 2,
                            Email = "adam@nowak.com",
                            FirstName = "Adam",
                            GroupId = 2,
                            LastName = "Nowak"
                        },
                        new
                        {
                            StudentId = 3,
                            Email = "arek@kedziora.com",
                            FirstName = "Arek",
                            GroupId = 3,
                            LastName = "Kedziora"
                        });
                });

            modelBuilder.Entity("StudentServiceSystemAPI.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ECTS")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("SubjectId");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            SubjectId = 1,
                            Description = "Biology subject",
                            ECTS = 0,
                            EndTime = new DateTime(2022, 11, 30, 17, 35, 8, 816, DateTimeKind.Utc).AddTicks(243),
                            Name = "Biology",
                            ScheduleId = 1,
                            StartTime = new DateTime(2022, 11, 30, 17, 35, 8, 816, DateTimeKind.Utc).AddTicks(240),
                            TeacherId = 1,
                            Type = 3
                        },
                        new
                        {
                            SubjectId = 2,
                            Description = "Math subject",
                            ECTS = 0,
                            EndTime = new DateTime(2022, 11, 30, 17, 35, 8, 816, DateTimeKind.Utc).AddTicks(244),
                            Name = "Math",
                            ScheduleId = 1,
                            StartTime = new DateTime(2022, 11, 30, 17, 35, 8, 816, DateTimeKind.Utc).AddTicks(244),
                            TeacherId = 2,
                            Type = 3
                        },
                        new
                        {
                            SubjectId = 3,
                            Description = "Computer Science subject",
                            ECTS = 0,
                            EndTime = new DateTime(2022, 11, 30, 17, 35, 8, 816, DateTimeKind.Utc).AddTicks(245),
                            Name = "Computer Science",
                            ScheduleId = 1,
                            StartTime = new DateTime(2022, 11, 30, 17, 35, 8, 816, DateTimeKind.Utc).AddTicks(245),
                            TeacherId = 3,
                            Type = 3
                        });
                });

            modelBuilder.Entity("StudentServiceSystemAPI.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"), 1L, 1);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            DepartmentId = 1,
                            Email = "kowalski@teacher.com",
                            FirstName = "Jan",
                            LastName = "Kowalski"
                        },
                        new
                        {
                            TeacherId = 2,
                            DepartmentId = 1,
                            Email = "nowak@teacher.com",
                            FirstName = "Adam",
                            LastName = "Nowak"
                        },
                        new
                        {
                            TeacherId = 3,
                            DepartmentId = 1,
                            Email = "monitor@teacher.com",
                            FirstName = "Michał",
                            LastName = "Monitor"
                        });
                });

            modelBuilder.Entity("StudentServiceSystemAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("StudentServiceSystemAPI.Models.Group", b =>
                {
                    b.HasOne("StudentServiceSystemAPI.Models.Department", null)
                        .WithMany("Groups")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentServiceSystemAPI.Models.Mark", b =>
                {
                    b.HasOne("StudentServiceSystemAPI.Models.Student", "Student")
                        .WithMany("Marks")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentServiceSystemAPI.Models.Subject", "Subject")
                        .WithMany("Marks")
                        .HasForeignKey("SubjectId");

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("StudentServiceSystemAPI.Models.Schedule", b =>
                {
                    b.HasOne("StudentServiceSystemAPI.Models.Group", "Group")
                        .WithOne("Schedule")
                        .HasForeignKey("StudentServiceSystemAPI.Models.Schedule", "GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("StudentServiceSystemAPI.Models.Student", b =>
                {
                    b.HasOne("StudentServiceSystemAPI.Models.Group", null)
                        .WithMany("Students")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentServiceSystemAPI.Models.Subject", b =>
                {
                    b.HasOne("StudentServiceSystemAPI.Models.Schedule", null)
                        .WithMany("Subjects")
                        .HasForeignKey("ScheduleId");

                    b.HasOne("StudentServiceSystemAPI.Models.Teacher", "Teacher")
                        .WithMany("Subjects")
                        .HasForeignKey("TeacherId");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("StudentServiceSystemAPI.Models.Teacher", b =>
                {
                    b.HasOne("StudentServiceSystemAPI.Models.Department", "Department")
                        .WithMany("Teachers")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("StudentServiceSystemAPI.Models.User", b =>
                {
                    b.HasOne("StudentServiceSystemAPI.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("StudentServiceSystemAPI.Models.Department", b =>
                {
                    b.Navigation("Groups");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("StudentServiceSystemAPI.Models.Group", b =>
                {
                    b.Navigation("Schedule")
                        .IsRequired();

                    b.Navigation("Students");
                });

            modelBuilder.Entity("StudentServiceSystemAPI.Models.Schedule", b =>
                {
                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("StudentServiceSystemAPI.Models.Student", b =>
                {
                    b.Navigation("Marks");
                });

            modelBuilder.Entity("StudentServiceSystemAPI.Models.Subject", b =>
                {
                    b.Navigation("Marks");
                });

            modelBuilder.Entity("StudentServiceSystemAPI.Models.Teacher", b =>
                {
                    b.Navigation("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
