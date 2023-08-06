using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Shared.DTOs;

public class StudentDTO
{
	public int? Id { get; set; }
	public string? LastName { get; set; }
	public string? FirstMidName { get; set; }

	public DateTime? EnrollmentDate { get; set; }


    public string? FullName { get; set; }
}

