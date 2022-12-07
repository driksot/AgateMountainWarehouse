using AgateMountainWarehouse.Api.Errors;
using Microsoft.AspNetCore.Mvc;

namespace AgateMountainWarehouse.Api.Controllers;

[Route("api/errors/{code}")]
[ApiController]
[ApiExplorerSettings(IgnoreApi = true)]
public class ErrorController : ControllerBase
{
    public IActionResult Error(int code)
    {
        return new ObjectResult(new ApiResponse(code));
    }
}
