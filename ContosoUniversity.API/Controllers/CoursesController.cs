using AutoMapper;
using ContosoUniversity.Data.Context;
using ContosoUniversity.Shared.DTOs.Courses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CoursesController : ControllerBase
{

	private readonly ContosoUniversityDbContext _dbcontext;


	private readonly IMapper _mapper;
	public CoursesController(ContosoUniversityDbContext dbcontext, IMapper mapper)
	{
		_dbcontext = dbcontext;
		_mapper = mapper;
	}



	[HttpGet]
	public async Task<ActionResult<IEnumerable<CourseDTO>>> GetCourses()
	{
		var courses = await _dbcontext.Courses
				.Include(c => c.Department)
				.AsNoTracking().ToListAsync();
		return Ok( _mapper.Map<IEnumerable<CourseDTO>>(courses));
	}


	[HttpGet("{id}")]
	public async Task<ActionResult<CourseDTO>> GetCourseById([FromRoute]int id)
	{
	var course = await _dbcontext.Courses.Include(c => c.Department).AsNoTracking().FirstOrDefaultAsync(c => c.CourseId == id);

		return Ok(_mapper.Map<CourseDTO>(course) );
	}
}
