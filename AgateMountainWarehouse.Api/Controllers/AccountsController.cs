using AgateMountainWarehouse.Api.Dtos;
using AgateMountainWarehouse.Api.Errors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AgateMountainWarehouse.Api.Controllers;

[Route("/api/accounts")]
[ApiController]
public class AccountsController : ControllerBase
{
    private readonly UserManager<IdentityUser> _userManager;

    public AccountsController(UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
    }

    [HttpPost("Registration")]
    public async Task<IActionResult> RegisterUser([FromBody] UserRegistrationDto userRegistration)
    {
        if (userRegistration is null || !ModelState.IsValid) return BadRequest(new ApiResponse(400));

        var user = new IdentityUser
        {
            UserName = userRegistration.Email,
            Email = userRegistration.Email
        };

        var result = await _userManager.CreateAsync(user, userRegistration.Password);
        if (!result.Succeeded)
        {
            var errors = result.Errors.Select(e => e.Description);

            return BadRequest(new RegistrationResponseDto { Errors = errors });
        }

        return StatusCode(StatusCodes.Status201Created);
    }
}
