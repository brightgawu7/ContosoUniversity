using ContosoUniversity.Data.Context;
using ContosoUniversity.Data.Core.IRepository;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data.Core.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{

	private readonly ContosoUniversityDbContext _dbcontext;

	public GenericRepository(ContosoUniversityDbContext dbcontext)
	{
		_dbcontext = dbcontext;
	}

	public async Task AddAsync(T entity)
	{
		await _dbcontext.Set<T>().AddAsync(entity);
	}

	public async Task DeleteAsync(T entity)
	{
		 _dbcontext.Set<T>().Remove(entity);
	}

	public async Task<IQueryable<T>> GetAllAsync()
	{
		return _dbcontext.Set<T>();
	}

	public virtual async Task<T?> GetAsync(int id)
	{
		return await _dbcontext.Set<T>().FindAsync(id);
	}

	public async Task UpdateAsync( T entity)
	{
		_dbcontext.Set<T>().Update(entity);
	}
}

