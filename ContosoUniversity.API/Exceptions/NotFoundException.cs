using System.Net;

namespace ContosoUniversity.API.Exceptions;
public class NotFoundException : GlobalException
{
	public NotFoundException(string message, HttpStatusCode statusCode = HttpStatusCode.NotFound) : base(message, statusCode) { }
}
