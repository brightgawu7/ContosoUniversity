using System.Net;

namespace ContosoUniversity.API.Exceptions;
public interface ICustomGlobalException
{
    string Status { get; set; }

    HttpStatusCode StatusCode { get; set; }

    string FormatErrorMessage();

}
