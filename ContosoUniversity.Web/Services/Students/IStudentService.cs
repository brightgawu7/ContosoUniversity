using ContosoUniversity.Shared.DTOs.Students;

namespace ContosoUniversity.Web.Services.Students;

public interface IStudentService
{
	Task GetStudents(string? name = null);

	Task<StudentDetailDTO> GetStudent(int Id);

	Task CreateStudent(CreateUpdateStudentDTO student);

	Task UpdateStudent(CreateUpdateStudentDTO student, int id);
	Task DeleteStudent(int id);
}
