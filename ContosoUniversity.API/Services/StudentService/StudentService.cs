using AutoMapper;
using ContosoUniversity.API.Exceptions;
using ContosoUniversity.Data.Core.Configuration;
using ContosoUniversity.Domain.Models;
using ContosoUniversity.Shared.DTOs.Students;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.API.Services.StudentService;
public class StudentService : IStudentService
{
	private readonly IUnitOfWork _unitOfWork;

	private readonly IMapper _mapper;
	public StudentService(IUnitOfWork unitOfWork, IMapper mapper)
	{
		_unitOfWork = unitOfWork;
		_mapper = mapper;
	}

	public async Task<StudentsDTO> CreateStudentAsync(CreateUpdateStudentDTO student)
	{
		var _student = _mapper.Map<Student>(student);

		await _unitOfWork.Student.AddAsync(_student);

		await _unitOfWork.CompleteAsync();

		return _mapper.Map<StudentsDTO>(_student);
	}

	public async Task DeleteSudentAsync(int id)
	{

		var student = await _unitOfWork.Student.GetAsync(id: id);

		if (student == null)
			throw new NotFoundException($"Student with id # {id} does not exist");

		await _unitOfWork.Student.DeleteAsync(student);
		await _unitOfWork.CompleteAsync();
	}

	public async Task<StudentDetailDTO> GetStudentAync(int id)
	{
		Student? student = await _unitOfWork.Student.GetAsync(id: id);


		if (student == null)
			throw new NotFoundException($"Student with id # {id} does not exist");

		return _mapper.Map<StudentDetailDTO>(student);

	}

	public async Task<IEnumerable<StudentsDTO>> GetStudentsAsync()
	{
		var students = await _unitOfWork.Student.GetAllAsync();


		return _mapper.Map<IEnumerable<StudentsDTO>>(await students.ToListAsync());
	}

	public async Task<StudentsResponseDTO> GetStudentsAsync(int page, string? sortOrder, string? searchName)
	{

		var students = await _unitOfWork.Student.GetAllAsync();

		sortOrder = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

		var pageResults = 10f;
		var pageCount = Math.Ceiling(students.Count() / pageResults);

		if (page <= 0)
			page = 1;



		if (!String.IsNullOrEmpty(searchName))
		{
			students = students.Where(s => s.LastName.Contains(searchName) || s.FirstMidName.Contains(searchName));
		}

		students = students.Skip((page - 1) * (int)pageResults).Take((int)pageResults);

		switch (sortOrder)
		{
			case "name_desc":
				students = students.OrderByDescending(s => s.LastName);
				break;
			case "date":
				students = students.OrderBy(s => s.EnrollmentDate);
				break;
			case "date_desc":
				students = students.OrderByDescending(s => s.EnrollmentDate);
				break;
			default:
				students = students.OrderBy(s => s.LastName);
				break;
		}

		var response = new StudentsResponseDTO
		{
			Students = _mapper.Map<IEnumerable<StudentsDTO>>(await students.ToListAsync()),
			CurrentPage = page,
			TotalPages = (int)pageCount
		};

		return response;
	}

	public async Task<StudentsDTO> UpdateStudentAsync(int id, CreateUpdateStudentDTO student)
	{
		var _student = await _unitOfWork.Student.GetAsync(id: id);

		if (_student == null)
			throw new NotFoundException($"Student with id # {id} does not exist");

		var updatedStudent = _mapper.Map(student, _student);

		await _unitOfWork.Student.UpdateAsync(updatedStudent);
		await _unitOfWork.CompleteAsync();

		return _mapper.Map<StudentsDTO>(updatedStudent);
	}
}
