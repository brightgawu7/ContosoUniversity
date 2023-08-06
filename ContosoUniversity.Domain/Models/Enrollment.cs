using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ContosoUniversity.Domain.Models;



[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Grade
{
	A = 1, B = 2, C = 3, D = 4, F = 4
}

public class Enrollment
{
	public int EnrollmentId { get; set; }
	public int CourseId { get; set; }
	public int StudentId { get; set; }

	[DisplayFormat(NullDisplayText = "No grade")]
	public Grade? Grade { get; set; }

	public Course? Course { get; set; }
	public Student? Student { get; set; }

}
