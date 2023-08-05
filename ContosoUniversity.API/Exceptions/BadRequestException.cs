using System.Net;

namespace ContosoUniversity.API.Exceptions;
public class BadRequestException : GlobalException
{
	public BadRequestException(string message, HttpStatusCode statusCode = HttpStatusCode.BadRequest) : base(message, statusCode) { }

}
