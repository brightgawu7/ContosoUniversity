using ContosoUniversity.Data.Context;
using ContosoUniversity.Data.Core.IRepository;
using ContosoUniversity.Data.Core.Repository;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data.Core.Configuration;

public class UnitOfWork : IUnitOfWork
{
	public IStudentRepository Student { get; private set; }



	private readonly ContosoUniversityDbContext _dbcontext;

	public UnitOfWork(ContosoUniversityDbContext dbcontext)
	{
		_dbcontext = dbcontext;
		Student = new StudentRepository(_dbcontext);
	}

	public async Task CompleteAsync()
	{
		await _dbcontext.SaveChangesAsync();
	}

	public void Dispose() => _dbcontext.Dispose();
}

