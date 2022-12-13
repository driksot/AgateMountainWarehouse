namespace AgateMountainWarehouse.Api.Dtos;

public class RegistrationResponseDto
{
    public bool IsSuccessfulRegistration { get; set; }
    public IEnumerable<string> Errors { get; set; } = new List<string>();
}
