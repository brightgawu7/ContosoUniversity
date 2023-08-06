using AutoMapper;
using ContosoUniversity.API.Exceptions;
using ContosoUniversity.Data.Context;
using ContosoUniversity.Domain.Models;
using ContosoUniversity.Shared.DTOs;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.API.Repository.StudentRepo;
public class StudentRepository : IStudentRepository
{

	private readonly ContosoUniversityDbContext _dbcontext;
	private readonly IMapper _mapper;
	public StudentRepository(ContosoUniversityDbContext dbcontext, IMapper mapper)
	{
		_dbcontext = dbcontext;
		_mapper = mapper;
	}

	public async Task<IEnumerable<StudentDTO>> GetStudents()
	{
		var students = await _dbcontext.Students.ToListAsync();

		return _mapper.Map<IEnumerable<StudentDTO>>(students);
	}

	public async Task<StudentsResponseDTO> GetStudents(int page, string? sortOrder, string? searchName)
	{
		sortOrder = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

		var pageResults = 10f;
		var pageCount = Math.Ceiling(_dbcontext.Students.Count() / pageResults);

		if (page <= 0)
			page = 1;


		IQueryable<Student> students = _dbcontext.Students;

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
			Students = _mapper.Map<IEnumerable<StudentDTO>>(await students.ToListAsync()),
			CurrentPage = page,
			TotalPages = (int)pageCount
		};

		return response;
	}
	public async Task<StudentDetailDTO> GetStudent(int id)
	{
		Student? student = await _dbcontext.Students.Include(s => s.Enrollments).ThenInclude(e => e.Course).AsNoTracking().FirstOrDefaultAsync(m => m.Id == id);

		if (student == null)
			throw new NotFoundException($"Student with id # {id} does not exist");

		return _mapper.Map<StudentDetailDTO>(student);
	}


	public async Task<StudentDTO> CreateStudent(CreateUpdateStudentDTO student)
	{
		var _student = _mapper.Map<Student>(student);

		var newStudent = _dbcontext.Add(_student);

		await _dbcontext.SaveChangesAsync();

		return _mapper.Map<StudentDTO>(newStudent.Entity);
	}



	public async Task<StudentDTO> UpdateStudent(int id, CreateUpdateStudentDTO student)
	{
		var _student = await _dbcontext.Students
						.FirstOrDefaultAsync(s => s.Id == id);

		if (_student == null)
			throw new NotFoundException($"Student with id # {id} does not exist");

		var updatedStudent = _mapper.Map(student, _student);

		await _dbcontext.SaveChangesAsync();

		return _mapper.Map<StudentDTO>(updatedStudent);
	}


	public async Task DeleteSudent(int id)
	{
		var student = await _dbcontext.Students
	   .FirstOrDefaultAsync(sh => sh.Id == id);


		if (student == null)
			throw new NotFoundException($"Student with id # {id} does not exist");

		_dbcontext.Students.Remove(student);
		await _dbcontext.SaveChangesAsync();
	}

}
