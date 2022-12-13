using AgateMountainWarehouse.Api.Dtos;
using AgateMountainWarehouse.Api.Errors;
using AgateMountainWarehouse.Api.TokenHelpers;
using AgateMountainWarehouse.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AgateMountainWarehouse.Api.Controllers;

[Route("/api/accounts")]
[ApiController]
public class AccountsController : ControllerBase
{
    private readonly UserManager<User> _userManager;
    private readonly ITokenService _tokenService;

    public AccountsController(
        UserManager<User> userManager, 
        ITokenService tokenService)
    {
        _userManager = userManager;
        _tokenService = tokenService;
    }

    [HttpPost("Registration")]
    public async Task<IActionResult> RegisterUser([FromBody] UserRegistrationDto userRegistration)
    {
        if (userRegistration is null || !ModelState.IsValid) return BadRequest(new ApiResponse(400));

        var user = new User
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

        await _userManager.AddToRoleAsync(user, "Employee");

        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] UserAuthenticationDto userAuthentication)
    {
        var user = await _userManager.FindByNameAsync(userAuthentication.Email);

        if (user is null || !await _userManager.CheckPasswordAsync(user, userAuthentication.Password))
            return Unauthorized(new AuthResponseDto { ErrorMessage = "Invalid Authentication" });

        var signingCredentials = _tokenService.GetSigningCredentials();
        var claims = await _tokenService.GetClaims(user);
        var tokenOptions = _tokenService.GenerateTokenOptions(signingCredentials, claims);
        var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

        user.RefreshToken = _tokenService.GenerateRefreshToken();
        user.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);

        await _userManager.UpdateAsync(user);

        return Ok(new AuthResponseDto { IsAuthSuccessful = true, Token = token, RefreshToken = user.RefreshToken });
    }
}
