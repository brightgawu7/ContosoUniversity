using ContosoUniversity.Shared.DTOs.Students;

namespace ContosoUniversity.Web.Store
{
	public interface IStudentState
	{
		IEnumerable<StudentsDTO>? Students { get; set; }

	}
}
