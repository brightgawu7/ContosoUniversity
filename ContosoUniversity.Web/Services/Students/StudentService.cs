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

	public async Task CreateStudent(CreateUpdateStudentDTO student)
	{
		await _http.PostAsJsonAsync("api/students", student);
		_navigationManager.NavigateTo("/Students");
	}

	public async Task DeleteStudent(int id)
	{
		await _http.DeleteAsync($"api/students/{id}");
		_navigationManager.NavigateTo("/Students");
	}

	public async Task<StudentDetailDTO> GetStudent(int Id)
	{
		var result = await _http.GetFromJsonAsync<ResponseFormat<StudentDetailDTO>>($"api/students/{Id}");
		if (result != null && result.Status == "success")
			return result.Data;
		throw new Exception("Hero not found!");
	}

	public async Task GetStudents(string? name = null)
	{
		var result = await _http.GetFromJsonAsync<ResponseFormat<StudentsResponseDTO>>($"api/students?searchName={name}");
		if (result != null && result.Status == "success")
			_studentState.Students = result.Data.Students;

	}

	public async Task UpdateStudent(CreateUpdateStudentDTO student, int id)
	{
		await _http.PutAsJsonAsync($"api/students/{id}", student);
		_navigationManager.NavigateTo("/Students");
	}
}
