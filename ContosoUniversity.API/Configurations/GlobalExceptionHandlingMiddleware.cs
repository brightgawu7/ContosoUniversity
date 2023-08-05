using System.Diagnostics;
using System.Text.Json;
using ContosoUniversity.API.Exceptions;

namespace ContosoUniversity.API.Configurations;
public class GlobalExceptionHandlingMiddleware
{
	private readonly RequestDelegate _next;

	public GlobalExceptionHandlingMiddleware(RequestDelegate next)
	{
		_next = next;
	}

	public async Task Invoke(HttpContext context)
	{
		try
		{
			await _next(context);
		}
		catch (GlobalException ex)
		{

			await HandleExceptionAsync(context, ex);
		}
	}


	private static Task HandleExceptionAsync(HttpContext context, GlobalException ex)
	{


		context.Response.ContentType = "application/json";
		context.Response.StatusCode = (int)ex.StatusCode;

		return context.Response.WriteAsync(ex.FormatErrorMessage());
	}
}
