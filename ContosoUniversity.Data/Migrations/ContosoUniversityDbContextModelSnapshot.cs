﻿// <auto-generated />
using System;
using ContosoUniversity.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContosoUniversity.Data.Migrations
{
    [DbContext(typeof(ContosoUniversityDbContext))]
    partial class ContosoUniversityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ContosoUniversity.Domain.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CourseId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Course", (string)null);

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            Credits = 3,
                            DepartmentId = 3,
                            Title = "Chemistry"
                        },
                        new
                        {
                            CourseId = 2,
                            Credits = 3,
                            DepartmentId = 4,
                            Title = "Microeconomics"
                        },
                        new
                        {
                            CourseId = 3,
                            Credits = 3,
                            DepartmentId = 4,
                            Title = "Macroeconomics"
                        },
                        new
                        {
                            CourseId = 4,
                            Credits = 4,
                            DepartmentId = 2,
                            Title = "Calculus"
                        },
                        new
                        {
                            CourseId = 5,
                            Credits = 4,
                            DepartmentId = 2,
                            Title = "Trigonometry"
                        },
                        new
                        {
                            CourseId = 6,
                            Credits = 3,
                            DepartmentId = 3,
                            Title = "Composition"
                        },
                        new
                        {
                            CourseId = 7,
                            Credits = 4,
                            DepartmentId = 3,
                            Title = "Literature"
                        });
                });

            modelBuilder.Entity("ContosoUniversity.Domain.Models.CourseAssignment", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "InstructorId");

                    b.HasIndex("InstructorId");

                    b.ToTable("CourseAssignment", (string)null);
                });

            modelBuilder.Entity("ContosoUniversity.Domain.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<decimal>("Budget")
                        .HasColumnType("money");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DepartmentId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Department", (string)null);

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            Budget = 350000m,
                            InstructorId = 1,
                            Name = "English",
                            StartDate = new DateTime(2007, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DepartmentId = 2,
                            Budget = 100000m,
                            InstructorId = 2,
                            Name = "Mathematics",
                            StartDate = new DateTime(2007, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DepartmentId = 3,
                            Budget = 350000m,
                            InstructorId = 4,
                            Name = "Engineering",
                            StartDate = new DateTime(2007, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DepartmentId = 4,
                            Budget = 100000m,
                            InstructorId = 5,
                            Name = "Economics",
                            StartDate = new DateTime(2007, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("ContosoUniversity.Domain.Models.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnrollmentId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("EnrollmentId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrollment", (string)null);

                    b.HasData(
                        new
                        {
                            EnrollmentId = 1,
                            CourseId = 1,
                            Grade = 1,
                            StudentId = 1
                        },
                        new
                        {
                            EnrollmentId = 2,
                            CourseId = 2,
                            Grade = 3,
                            StudentId = 1
                        },
                        new
                        {
                            EnrollmentId = 3,
                            CourseId = 3,
                            Grade = 2,
                            StudentId = 1
                        },
                        new
                        {
                            EnrollmentId = 4,
                            CourseId = 4,
                            Grade = 2,
                            StudentId = 2
                        },
                        new
                        {
                            EnrollmentId = 5,
                            CourseId = 5,
                            Grade = 4,
                            StudentId = 2
                        },
                        new
                        {
                            EnrollmentId = 6,
                            CourseId = 6,
                            Grade = 4,
                            StudentId = 2
                        },
                        new
                        {
                            EnrollmentId = 7,
                            CourseId = 1,
                            StudentId = 3
                        },
                        new
                        {
                            EnrollmentId = 8,
                            CourseId = 1,
                            StudentId = 4
                        },
                        new
                        {
                            EnrollmentId = 9,
                            CourseId = 2,
                            Grade = 4,
                            StudentId = 4
                        },
                        new
                        {
                            EnrollmentId = 10,
                            CourseId = 3,
                            Grade = 3,
                            StudentId = 5
                        },
                        new
                        {
                            EnrollmentId = 11,
                            CourseId = 4,
                            StudentId = 6
                        },
                        new
                        {
                            EnrollmentId = 12,
                            CourseId = 7,
                            Grade = 1,
                            StudentId = 7
                        });
                });

            modelBuilder.Entity("ContosoUniversity.Domain.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstMidName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("FirstName");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Instructor", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstMidName = "Kim",
                            HireDate = new DateTime(1995, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Abercrombie"
                        },
                        new
                        {
                            Id = 2,
                            FirstMidName = "Fadi",
                            HireDate = new DateTime(2002, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Fakhouri"
                        },
                        new
                        {
                            Id = 3,
                            FirstMidName = "Roger",
                            HireDate = new DateTime(1998, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Harui"
                        },
                        new
                        {
                            Id = 4,
                            FirstMidName = "Candace",
                            HireDate = new DateTime(2001, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Kapoor"
                        },
                        new
                        {
                            Id = 5,
                            FirstMidName = "Roger",
                            HireDate = new DateTime(2004, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Zheng"
                        });
                });

            modelBuilder.Entity("ContosoUniversity.Domain.Models.OfficeAssignment", b =>
                {
                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("InstructorId");

                    b.ToTable("OfficeAssignment", (string)null);

                    b.HasData(
                        new
                        {
                            InstructorId = 2,
                            Location = "Smith 17"
                        },
                        new
                        {
                            InstructorId = 3,
                            Location = "Gowan 27"
                        },
                        new
                        {
                            InstructorId = 4,
                            Location = "Thompson 304"
                        });
                });

            modelBuilder.Entity("ContosoUniversity.Domain.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstMidName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Student", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EnrollmentDate = new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstMidName = "Carson",
                            LastName = "Alexander"
                        },
                        new
                        {
                            Id = 2,
                            EnrollmentDate = new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstMidName = "Meredith",
                            LastName = "Alonso"
                        },
                        new
                        {
                            Id = 3,
                            EnrollmentDate = new DateTime(2003, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstMidName = "Arturo",
                            LastName = "Anand"
                        },
                        new
                        {
                            Id = 4,
                            EnrollmentDate = new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstMidName = "Gytis",
                            LastName = "Barzdukas"
                        },
                        new
                        {
                            Id = 5,
                            EnrollmentDate = new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstMidName = "Yan",
                            LastName = "Li"
                        },
                        new
                        {
                            Id = 6,
                            EnrollmentDate = new DateTime(2001, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstMidName = "Peggy",
                            LastName = "Justice"
                        },
                        new
                        {
                            Id = 7,
                            EnrollmentDate = new DateTime(2003, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstMidName = "Laura",
                            LastName = "Norman"
                        },
                        new
                        {
                            Id = 8,
                            EnrollmentDate = new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstMidName = "Nino",
                            LastName = "Olivetto"
                        });
                });

            modelBuilder.Entity("ContosoUniversity.Domain.Models.Course", b =>
                {
                    b.HasOne("ContosoUniversity.Domain.Models.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ContosoUniversity.Domain.Models.CourseAssignment", b =>
                {
                    b.HasOne("ContosoUniversity.Domain.Models.Course", "Course")
                        .WithMany("CourseAssignments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ContosoUniversity.Domain.Models.Instructor", "Instructor")
                        .WithMany("CourseAssignments")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("ContosoUniversity.Domain.Models.Department", b =>
                {
                    b.HasOne("ContosoUniversity.Domain.Models.Instructor", "Administrator")
                        .WithMany()
                        .HasForeignKey("InstructorId");

                    b.Navigation("Administrator");
                });

            modelBuilder.Entity("ContosoUniversity.Domain.Models.Enrollment", b =>
                {
                    b.HasOne("ContosoUniversity.Domain.Models.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ContosoUniversity.Domain.Models.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ContosoUniversity.Domain.Models.OfficeAssignment", b =>
                {
                    b.HasOne("ContosoUniversity.Domain.Models.Instructor", "Instructor")
                        .WithOne("OfficeAssignment")
                        .HasForeignKey("ContosoUniversity.Domain.Models.OfficeAssignment", "InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("ContosoUniversity.Domain.Models.Course", b =>
                {
                    b.Navigation("CourseAssignments");

                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("ContosoUniversity.Domain.Models.Department", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("ContosoUniversity.Domain.Models.Instructor", b =>
                {
                    b.Navigation("CourseAssignments");

                    b.Navigation("OfficeAssignment")
                        .IsRequired();
                });

            modelBuilder.Entity("ContosoUniversity.Domain.Models.Student", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
