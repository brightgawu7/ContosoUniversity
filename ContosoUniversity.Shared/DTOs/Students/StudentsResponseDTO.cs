namespace ContosoUniversity.Shared.DTOs.Students;
public class StudentsResponseDTO
{
    public IEnumerable<StudentsDTO> Students { get; set; } = new List<StudentsDTO>();
    public int TotalPages { get; set; }

    public int CurrentPage { get; set; }
}
