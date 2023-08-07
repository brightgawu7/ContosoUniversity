using ContosoUniversity.Shared.DTOs.Students;

namespace ContosoUniversity.Web.Store
{
	public class StudentState:IStudentState
	{
		public IEnumerable<StudentsDTO>? Students { get; set; }
	}
}
