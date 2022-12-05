namespace AgateMountainWarehouse.Api.Errors;

public class ApiResponse
{
	public int StatusCode { get; set; }
	public string? Message { get; set; }

	public ApiResponse(int statusCode, string? message = null)
	{
		StatusCode = statusCode;
		Message = message ?? GetDefaultMessageForStatusCode(statusCode);
	}

	private string GetDefaultMessageForStatusCode(int statusCode)
	{
		return statusCode switch
		{
			400 => "A bad request was made",
			401 => "You are not authorized",
			404 => "The resource was not found",
			500 => "There was a server error",
			_ => "An unknown error has occurred."
		};
	}
}
