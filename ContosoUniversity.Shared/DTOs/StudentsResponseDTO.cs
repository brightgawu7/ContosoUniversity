namespace ContosoUniversity.Shared.DTOs;
public class StudentsResponseDTO
{
	public IEnumerable<StudentDTO> Students { get; set; } = new List<StudentDTO>();
	public int TotalPages { get; set; }

	public int CurrentPage { get; set; }
}
