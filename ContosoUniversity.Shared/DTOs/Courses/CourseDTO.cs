namespace ContosoUniversity.Shared.DTOs.Courses;

public class CourseDTO
{
	public int? CourseId { get; set; }
	public string? Title { get; set; }
	public int? Credits { get; set; }

	public CourseDepartmentDTO? Department { get; set; }
}

