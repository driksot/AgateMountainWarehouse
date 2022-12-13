namespace AgateMountainWarehouse.Client.ViewModels;

public class RegistrationResponseViewModel
{
    public bool IsSuccessfulRegistration { get; set; }
    public IEnumerable<string> Errors { get; set; } = new List<string>();
}
