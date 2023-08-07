using ContosoUniversity.Shared.DTOs.Students;

namespace ContosoUniversity.API.Services.StudentService;
public interface IStudentService
{
	Task<IEnumerable<StudentsDTO>> GetStudentsAsync();
	Task<StudentsResponseDTO> GetStudentsAsync(int page, string? sortOrder, string? searchName);
	Task<StudentDetailDTO> GetStudentAync(int id);

	Task<StudentsDTO> CreateStudentAsync(CreateUpdateStudentDTO student);
	Task<StudentsDTO> UpdateStudentAsync(int id, CreateUpdateStudentDTO student);

	Task DeleteSudentAsync(int id);

}
