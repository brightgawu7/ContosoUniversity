using ContosoUniversity.Domain.Models;
using ContosoUniversity.Shared.DTOs;

namespace ContosoUniversity.API.Repository.StudentRepo;
public interface IStudentRepository
{
	Task<IEnumerable<StudentDTO>> GetStudents();
	Task<StudentDetailDTO> GetStudent(int id);

	Task<StudentDTO> CreateStudent(CreateUpdateStudentDTO student);
	Task<StudentDTO> UpdateStudent(int id, CreateUpdateStudentDTO student);

	Task DeleteSudent(int id);
}
