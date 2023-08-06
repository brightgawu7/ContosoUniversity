using ContosoUniversity.API.Common;
using ContosoUniversity.API.Repository.StudentRepo;
using ContosoUniversity.Domain.Models;
using ContosoUniversity.Shared.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.API.Controllers;


[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
	private readonly IStudentRepository _studentRepository;

	public StudentsController(IStudentRepository studentRepository)
	{
		_studentRepository = studentRepository;
	}


	[HttpGet]
	public async Task<ActionResult<ResponseFormat<IEnumerable<StudentDTO>>>> GetStudents()
	{
		var response = new ResponseFormat<IEnumerable<StudentDTO>>
		{
			Data = await _studentRepository.GetStudents()
		};

		return Ok(response);
	}


	[HttpGet("{Id}")]
	public async Task<ActionResult<ResponseFormat<StudentDetailDTO>>> GetStudent([FromRoute] int Id)
	{
		var response = new ResponseFormat<StudentDetailDTO>
		{
			Data = await _studentRepository.GetStudent(id: Id)
		};

		return Ok(response);

	}


	[HttpPost]
	public async Task<ActionResult<ResponseFormat<StudentDTO>>> CreateStudent([FromBody] CreateUpdateStudentDTO student)
	{


		var response = new ResponseFormat<StudentDTO>
		{
			Data = await _studentRepository.CreateStudent(student: student)
		};

		return Ok(response);
	}

	[HttpPut("{id}")]
	public async Task<ActionResult<StudentDTO>> UpdateStudent([FromRoute] int id, [FromBody] CreateUpdateStudentDTO student)
	{

		var response = new ResponseFormat<StudentDTO>
		{
			Data = await _studentRepository.UpdateStudent(id: id, student: student)
		};

		return Ok(response);
	}


	[HttpDelete("{id}")]
	public async Task<ActionResult> DeleteStudent(int id)
	{
		
		await _studentRepository.DeleteSudent(id);

		return NoContent();
	}
}
