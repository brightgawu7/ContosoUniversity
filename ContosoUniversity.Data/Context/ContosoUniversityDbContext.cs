using ContosoUniversity.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data.Context;

public class ContosoUniversityDbContext : DbContext
{
	public ContosoUniversityDbContext(DbContextOptions<ContosoUniversityDbContext> options) : base(options) { }

	public DbSet<Course> Courses { get; set; }
	public DbSet<Enrollment> Enrollments { get; set; }

	public DbSet<Student> Students { get; set; }


	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Course>().ToTable("Course");
		modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
		modelBuilder.Entity<Student>().ToTable("Student");


		#region Seed Into Database

		//modelBuilder.Entity<Student>().HasData(
		//	new Student { Id = 1, FirstMidName = "Carson", LastName = "Alexander", EnrollmentDate = DateTime.Parse("2005-09-01") },
		//	new Student { Id = 2, FirstMidName = "Meredith", LastName = "Alonso", EnrollmentDate = DateTime.Parse("2002-09-01") },
		//	new Student { Id = 3, FirstMidName = "Arturo", LastName = "Anand", EnrollmentDate = DateTime.Parse("2003-09-01") },
		//	new Student { Id = 4, FirstMidName = "Gytis", LastName = "Barzdukas", EnrollmentDate = DateTime.Parse("2002-09-01") },
		//	new Student { Id = 5, FirstMidName = "Yan", LastName = "Li", EnrollmentDate = DateTime.Parse("2002-09-01") },
		//	new Student { Id = 6, FirstMidName = "Peggy", LastName = "Justice", EnrollmentDate = DateTime.Parse("2001-09-01") },
		//	new Student { Id = 7, FirstMidName = "Laura", LastName = "Norman", EnrollmentDate = DateTime.Parse("2003-09-01") },
		//	new Student { Id = 8, FirstMidName = "Nino", LastName = "Olivetto", EnrollmentDate = DateTime.Parse("2005-09-01") }

		//	);

		//modelBuilder.Entity<Course>().HasData(
		//	new Course { CourseId = 1, Title = "Chemistry", Credits = 3 },
		//	new Course { CourseId = 2, Title = "Microeconomics", Credits = 3 },
		//	new Course { CourseId = 3, Title = "Macroeconomics", Credits = 3 },
		//	new Course { CourseId = 4, Title = "Calculus", Credits = 4 },
		//	new Course { CourseId = 5, Title = "Trigonometry", Credits = 4 },
		//	new Course { CourseId = 6, Title = "Composition", Credits = 3 },
		//	new Course { CourseId = 7, Title = "Literature", Credits = 4 }

		//	);

		//modelBuilder.Entity<Enrollment>().HasData(
		//	new Enrollment { EnrollmentId = 1, StudentId = 1, CourseId = 1, Grade = Grade.A },
		//	new Enrollment { EnrollmentId = 2, StudentId = 1, CourseId = 2, Grade = Grade.C },
		//	new Enrollment { EnrollmentId = 3, StudentId = 1, CourseId = 3, Grade = Grade.B },
		//	new Enrollment { EnrollmentId = 4, StudentId = 2, CourseId = 4, Grade = Grade.B },
		//	new Enrollment { EnrollmentId = 5, StudentId = 2, CourseId = 5, Grade = Grade.F },
		//	new Enrollment { EnrollmentId = 6, StudentId = 2, CourseId = 6, Grade = Grade.F },
		//	new Enrollment { EnrollmentId = 7, StudentId = 3, CourseId = 1 },
		//	new Enrollment { EnrollmentId = 8, StudentId = 4, CourseId = 1 },
		//	new Enrollment { EnrollmentId = 9, StudentId = 4, CourseId = 2, Grade = Grade.F },
		//	new Enrollment { EnrollmentId = 10, StudentId = 5, CourseId = 3, Grade = Grade.C },
		//	new Enrollment { EnrollmentId = 11, StudentId = 6, CourseId = 4 },
		//	new Enrollment { EnrollmentId = 12, StudentId = 7, CourseId = 7, Grade = Grade.A }
		//	);
		#endregion
	}

}

