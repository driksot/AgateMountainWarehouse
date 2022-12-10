using AgateMountainWarehouse.Api.Dtos;
using AgateMountainWarehouse.Api.Errors;
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
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IConfiguration _configuration;
    private readonly IConfigurationSection _configurationSection;

    public AccountsController(UserManager<IdentityUser> userManager, IConfiguration configuration)
    {
        _userManager = userManager;
        _configuration = configuration;
        _configurationSection = _configuration.GetSection("JwtSettings");
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

        await _userManager.AddToRoleAsync(user, "Employee");

        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] UserAuthenticationDto userAuthentication)
    {
        var user = await _userManager.FindByNameAsync(userAuthentication.Email);

        if (user is null || !await _userManager.CheckPasswordAsync(user, userAuthentication.Password))
            return Unauthorized(new AuthResponseDto { ErrorMessage = "Invalid Authentication" });

        var signingCredentials = GetSigningCredentials();
        var claims = await GetClaims(user);
        var tokenOptions = GernerateTokenOptions(signingCredentials, claims);
        var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

        return Ok(new AuthResponseDto { IsAuthSuccessful = true, Token = token });
    }

    private JwtSecurityToken GernerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
    {
        var tokenOptions = new JwtSecurityToken(
        issuer: _configurationSection["validIssuer"],
        audience: _configurationSection["validAudience"],
        claims: claims,
        expires: DateTime.Now.AddMinutes(Convert.ToDouble(_configurationSection["expiryInMinutes"])),
        signingCredentials: signingCredentials);

        return tokenOptions;
    }

    private async Task<List<Claim>> GetClaims(IdentityUser user)
    {
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.Email)
        };

        var roles = await _userManager.GetRolesAsync(user);
        foreach (var role in roles)
        {
            claims.Add(new Claim(ClaimTypes.Role, role));
        }

        return claims;
    }

    private SigningCredentials GetSigningCredentials()
    {
        var key = Encoding.UTF8.GetBytes(_configurationSection["securityKey"]);
        var secret = new SymmetricSecurityKey(key);

        return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
    }
}
