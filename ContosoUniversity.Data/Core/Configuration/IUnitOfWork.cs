using ContosoUniversity.Data.Core.IRepository;

namespace ContosoUniversity.Data.Core.Configuration;

public interface IUnitOfWork:IDisposable
{
	IStudentRepository Student { get; }

	Task CompleteAsync();

}

