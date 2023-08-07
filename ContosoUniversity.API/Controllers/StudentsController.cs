using ContosoUniversity.API.Services.StudentService;
using ContosoUniversity.Shared.DTOs.Students;
using ContosoUniversity.Shared.ResponseFormats;
using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.API.Controllers;


[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{

	private readonly IStudentService _studentService;
	public StudentsController( IStudentService studentService)
	{
		_studentService = studentService;
	}




	[HttpGet]
	public async Task<ActionResult<ResponseFormat<StudentsResponseDTO>>> GetStudents([FromQuery] int page, [FromQuery] string? sortOrder, [FromQuery] string? searchName)
	{




		var response = new ResponseFormat<StudentsResponseDTO>
		{
			Data = await _studentService.GetStudentsAsync(page: page, sortOrder: sortOrder, searchName: searchName)
		};

		return Ok(response);
	}



	[HttpGet("{Id}")]
	public async Task<ActionResult<ResponseFormat<StudentDetailDTO>>> GetStudent([FromRoute] int Id)
	{
		var response = new ResponseFormat<StudentDetailDTO>
		{
			Data = await _studentService.GetStudentAync(id: Id)
		};

		return Ok(response);

	}


	[HttpPost]
	public async Task<ActionResult<ResponseFormat<StudentsDTO>>> CreateStudent([FromBody] CreateUpdateStudentDTO student)
	{


		var response = new ResponseFormat<StudentsDTO>
		{
			Data = await _studentService.CreateStudentAsync(student: student)
		};

		return Ok(response);
	}

	[HttpPut("{id}")]
	public async Task<ActionResult<StudentsDTO>> UpdateStudent([FromRoute] int id, [FromBody] CreateUpdateStudentDTO student)
	{

		var response = new ResponseFormat<StudentsDTO>
		{
			Data = await _studentService.UpdateStudentAsync(id: id, student: student)
		};

		return Ok(response);
	}


	[HttpDelete("{id}")]
	public async Task<ActionResult> DeleteStudent(int id)
	{

		await _studentService.DeleteSudentAsync(id:id);

		return NoContent();
	}
}
