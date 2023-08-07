using System.Net.Http.Json;
using ContosoUniversity.Shared.DTOs.Students;
using ContosoUniversity.Shared.ResponseFormats;
using ContosoUniversity.Web.Store;
using Microsoft.AspNetCore.Components;

namespace ContosoUniversity.Web.Services.Students;
public class StudentService:IStudentService
{
	private readonly HttpClient _http;

	private readonly NavigationManager _navigationManager;
	private readonly IStudentState _studentState;

	public StudentService(NavigationManager navigationManager, HttpClient http, IStudentState studentState)
	{
		_navigationManager = navigationManager;
		_http = http;
		_studentState = studentState;
	}

	public Task CreateStudent(CreateUpdateStudentDTO student)
	{
		throw new NotImplementedException();
	}

	public Task DeleteStudent(int id)
	{
		throw new NotImplementedException();
	}

	public Task<StudentDetailDTO> GetStudent(int Id)
	{
		throw new NotImplementedException();
	}

	public async Task GetStudents(string? name = null)
	{
		var result = await _http.GetFromJsonAsync<ResponseFormat<StudentsResponseDTO>>($"api/students?searchName={name}");
		if (result != null && result.Status == "success")
			_studentState.Students = result.Data.Students;

	}

	public Task UpdateStudent(CreateUpdateStudentDTO student, int id)
	{
		throw new NotImplementedException();
	}
}
