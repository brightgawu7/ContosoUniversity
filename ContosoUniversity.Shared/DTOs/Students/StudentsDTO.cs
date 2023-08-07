
namespace ContosoUniversity.Shared.DTOs.Students;

public class StudentsDTO
{
    public int? Id { get; set; }
    public string? LastName { get; set; }
    public string? FirstMidName { get; set; }

    public DateTime? EnrollmentDate { get; set; }


    public string? FullName { get; set; }
}

