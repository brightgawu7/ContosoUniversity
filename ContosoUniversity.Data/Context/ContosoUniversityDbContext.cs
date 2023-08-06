using ContosoUniversity.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUniversity.Data.Context;

public class ContosoUniversityDbContext : DbContext
{
	public ContosoUniversityDbContext(DbContextOptions<ContosoUniversityDbContext> options) : base(options) { }

	public DbSet<Course> Courses { get; set; }
	public DbSet<Enrollment> Enrollments { get; set; }

	public DbSet<Student> Students { get; set; }
	public DbSet<Department> Departments { get; set; }
	public DbSet<Instructor> Instructors { get; set; }
	public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
	public DbSet<CourseAssignment> CourseAssignments { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Course>().ToTable("Course");
		modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
		modelBuilder.Entity<Student>().ToTable("Student");
		modelBuilder.Entity<Department>().ToTable("Department");
		modelBuilder.Entity<Instructor>().ToTable("Instructor");
		modelBuilder.Entity<OfficeAssignment>().ToTable("OfficeAssignment");
		modelBuilder.Entity<CourseAssignment>().ToTable("CourseAssignment");
		modelBuilder.Entity<CourseAssignment>()
					.HasKey(c => new { c.CourseId, c.InstructorId });

		#region Seed Into Database

		modelBuilder.Entity<Student>().HasData(
			new Student { Id = 1, FirstMidName = "Carson", LastName = "Alexander", EnrollmentDate = DateTime.Parse("2005-09-01") },
			new Student { Id = 2, FirstMidName = "Meredith", LastName = "Alonso", EnrollmentDate = DateTime.Parse("2002-09-01") },
			new Student { Id = 3, FirstMidName = "Arturo", LastName = "Anand", EnrollmentDate = DateTime.Parse("2003-09-01") },
			new Student { Id = 4, FirstMidName = "Gytis", LastName = "Barzdukas", EnrollmentDate = DateTime.Parse("2002-09-01") },
			new Student { Id = 5, FirstMidName = "Yan", LastName = "Li", EnrollmentDate = DateTime.Parse("2002-09-01") },
			new Student { Id = 6, FirstMidName = "Peggy", LastName = "Justice", EnrollmentDate = DateTime.Parse("2001-09-01") },
			new Student { Id = 7, FirstMidName = "Laura", LastName = "Norman", EnrollmentDate = DateTime.Parse("2003-09-01") },
			new Student { Id = 8, FirstMidName = "Nino", LastName = "Olivetto", EnrollmentDate = DateTime.Parse("2005-09-01") }

			);

		modelBuilder.Entity<Instructor>().HasData(
			 new Instructor
			 {
				 Id = 1,
				 FirstMidName = "Kim",
				 LastName = "Abercrombie",
				 HireDate = DateTime.Parse("1995-03-11")
			 },
				new Instructor
				{
					Id = 2,
					FirstMidName = "Fadi",
					LastName = "Fakhouri",
					HireDate = DateTime.Parse("2002-07-06")
				},
				new Instructor
				{
					Id = 3,
					FirstMidName = "Roger",
					LastName = "Harui",
					HireDate = DateTime.Parse("1998-07-01")
				},
				new Instructor
				{
					Id = 4,
					FirstMidName = "Candace",
					LastName = "Kapoor",
					HireDate = DateTime.Parse("2001-01-15")
				},
				new Instructor
				{
					Id = 5,
					FirstMidName = "Roger",
					LastName = "Zheng",
					HireDate = DateTime.Parse("2004-02-12")
				}
			);

		modelBuilder.Entity<Department>().HasData(
			new Department
			{
				DepartmentId = 1,
				Name = "English",
				Budget = 350000,
				StartDate = DateTime.Parse("2007-09-01"),
				InstructorId = 1
			},
				new Department
				{
					DepartmentId = 2,
					Name = "Mathematics",
					Budget = 100000,
					StartDate = DateTime.Parse("2007-09-01"),
					InstructorId = 2
				},
				new Department
				{
					DepartmentId = 3,
					Name = "Engineering",
					Budget = 350000,
					StartDate = DateTime.Parse("2007-09-01"),
					InstructorId = 4
				},
				new Department
				{
					DepartmentId = 4,
					Name = "Economics",
					Budget = 100000,
					StartDate = DateTime.Parse("2007-09-01"),
					InstructorId = 5
				}

			);
		modelBuilder.Entity<Course>().HasData(
			new Course { CourseId = 1, Title = "Chemistry", Credits = 3, DepartmentId = 3 },
			new Course { CourseId = 2, Title = "Microeconomics", Credits = 3, DepartmentId = 4 },
			new Course { CourseId = 3, Title = "Macroeconomics", Credits = 3, DepartmentId = 4 },
			new Course { CourseId = 4, Title = "Calculus", Credits = 4, DepartmentId = 2 },
			new Course { CourseId = 5, Title = "Trigonometry", Credits = 4, DepartmentId = 2 },
			new Course { CourseId = 6, Title = "Composition", Credits = 3, DepartmentId = 3 },
			new Course { CourseId = 7, Title = "Literature", Credits = 4, DepartmentId = 3 }

			);

		modelBuilder.Entity<OfficeAssignment>().HasData(
							new OfficeAssignment
							{
								InstructorId = 2,
								Location = "Smith 17"
							},
				new OfficeAssignment
				{
					InstructorId = 3,
					Location = "Gowan 27"
				},
				new OfficeAssignment
				{
					InstructorId = 4,
					Location = "Thompson 304"
				}


			);

		//modelBuilder.Entity<CourseAssignment>().HasData(
		//	new CourseAssignment
		//{
		//	CourseId = 1,
		//	InstructorId = 2
		//},
		//		new CourseAssignment
		//		{
		//			CourseId = 1,
		//			InstructorId = 2
		//		},
		//		new CourseAssignment
		//		{
		//			CourseId = 2,
		//			InstructorId = 1
		//		},
		//		new CourseAssignment
		//		{
		//			CourseId = 3,
		//			InstructorId = 3
		//		},
		//		new CourseAssignment
		//		{
		//			CourseId = 4,
		//			InstructorId = 3
		//		},
		//		new CourseAssignment
		//		{
		//			CourseId = 4,
		//			InstructorId = 3
		//		},
		//		new CourseAssignment
		//		{
		//			CourseId = 1,
		//			InstructorId = 2
		//		}
		//			);

		modelBuilder.Entity<Enrollment>().HasData(
			new Enrollment { EnrollmentId = 1, StudentId = 1, CourseId = 1, Grade = Grade.A },
			new Enrollment { EnrollmentId = 2, StudentId = 1, CourseId = 2, Grade = Grade.C },
			new Enrollment { EnrollmentId = 3, StudentId = 1, CourseId = 3, Grade = Grade.B },
			new Enrollment { EnrollmentId = 4, StudentId = 2, CourseId = 4, Grade = Grade.B },
			new Enrollment { EnrollmentId = 5, StudentId = 2, CourseId = 5, Grade = Grade.F },
			new Enrollment { EnrollmentId = 6, StudentId = 2, CourseId = 6, Grade = Grade.F },
			new Enrollment { EnrollmentId = 7, StudentId = 3, CourseId = 1 },
			new Enrollment { EnrollmentId = 8, StudentId = 4, CourseId = 1 },
			new Enrollment { EnrollmentId = 9, StudentId = 4, CourseId = 2, Grade = Grade.F },
			new Enrollment { EnrollmentId = 10, StudentId = 5, CourseId = 3, Grade = Grade.C },
			new Enrollment { EnrollmentId = 11, StudentId = 6, CourseId = 4 },
			new Enrollment { EnrollmentId = 12, StudentId = 7, CourseId = 7, Grade = Grade.A }
			);
		#endregion
	}

}

