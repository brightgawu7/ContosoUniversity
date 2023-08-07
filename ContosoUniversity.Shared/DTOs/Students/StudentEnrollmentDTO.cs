namespace ContosoUniversity.Shared.DTOs.Students;

public enum Grade
{
    A = 1, B = 2, C = 3, D = 4, F = 4
}
public class StudentEnrollmentDTO
{
    public int? EnrollmentId { get; set; }
    public int? CourseId { get; set; }
    public int? StudentId { get; set; }
    public Grade? Grade { get; set; }

    public StudentCourseDTO? Course { get; set; }
}

