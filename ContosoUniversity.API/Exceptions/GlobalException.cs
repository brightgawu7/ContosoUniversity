using System.Net;
using System.Text.Json;

namespace ContosoUniversity.API.Exceptions;
public class GlobalException : Exception, ICustomGlobalException
{
	protected virtual string ErrorMessage { get; set; } 
	public virtual string Status { get; set; }

	public virtual HttpStatusCode StatusCode { get; set; }

	public GlobalException(string message, HttpStatusCode httpStatusCode) : base(message)
	{
		ErrorMessage = message;
		Status = "error";
		StatusCode = httpStatusCode;

	}

	public virtual string FormatErrorMessage()
	{

		return JsonSerializer.Serialize(new { status = StatusCode, message = ErrorMessage });
	}

}
