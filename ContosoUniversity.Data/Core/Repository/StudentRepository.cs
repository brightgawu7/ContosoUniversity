using ContosoUniversity.Data.Context;
using ContosoUniversity.Data.Core.IRepository;
using ContosoUniversity.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data.Core.Repository;

public class StudentRepository : GenericRepository<Student>, IStudentRepository
{
	private readonly ContosoUniversityDbContext _dbcontext;

	public StudentRepository(ContosoUniversityDbContext dbcontext) : base(dbcontext: dbcontext)
	{
		_dbcontext = dbcontext;
	}
	public override async Task<Student?> GetAsync(int id)
	{
		return await _dbcontext.Students.Include(s => s.Enrollments).ThenInclude(e => e.Course).AsNoTracking().FirstOrDefaultAsync(m => m.Id == id);
	}

}

