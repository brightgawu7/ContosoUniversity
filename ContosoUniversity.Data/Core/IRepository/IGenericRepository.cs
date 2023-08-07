namespace ContosoUniversity.Data.Core.IRepository;

public interface IGenericRepository<T> where T : class
{
	Task<T?> GetAsync(int id);

	Task<IQueryable<T>> GetAllAsync();

	Task AddAsync(T entity);

	Task UpdateAsync(T entity);

	Task DeleteAsync(T entity);
}

