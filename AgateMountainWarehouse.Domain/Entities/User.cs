using Microsoft.AspNetCore.Identity;

namespace AgateMountainWarehouse.Domain.Entities;

public class User : IdentityUser
{
    public string RefreshToken { get; set; } = string.Empty;
    public DateTime RefreshTokenExpiryTime { get; set; }
}
