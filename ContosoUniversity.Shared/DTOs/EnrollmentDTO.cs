namespace ContosoUniversity.Shared.DTOs;

public enum Grade
{
	A = 1, B = 2, C = 3, D = 4, F = 4
}
public class EnrollmentDTO
{
	public int? EnrollmentId { get; set; }
	public int? CourseId { get; set; }
	public int? StudentId { get; set; }
	public Grade? Grade { get; set; }

	public CourseDTO? Course { get; set; }
}

