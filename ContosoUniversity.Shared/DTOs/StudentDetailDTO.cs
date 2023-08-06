namespace ContosoUniversity.Shared.DTOs;

public class StudentDetailDTO
{
	public int Id { get; set; }
	public string? LastName { get; set; }
	public string? FirstMidName { get; set; }
	public DateTime EnrollmentDate { get; set; }

	public ICollection<EnrollmentDTO>? Enrollments { get; set; }
}

