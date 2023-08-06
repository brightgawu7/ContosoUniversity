using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ContosoUniversity.Domain.Models;
public class Course
{
	[Display(Name = "Number")]
	public int CourseId { get; set; }

	[StringLength(50, MinimumLength = 3)]
	public string Title { get; set; } = string.Empty;
	
	[Range(0, 5)]
	public int Credits { get; set; }

	public int DepartmentId { get; set; }

	public Department Department { get; set; }


	public ICollection<Enrollment>? Enrollments { get; set; }

	public ICollection<CourseAssignment> CourseAssignments { get; set; }
}

