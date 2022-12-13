using AgateMountainWarehouse.Client.ViewModels;

namespace AgateMountainWarehouse.Client.HttpRepository;

public interface IAuthenticationService
{
    Task<RegistrationResponseViewModel> RegisterUser(UserRegistrationViewModel userForRegistration);
    Task<AuthResponseViewModel> Login(UserAuthenticationViewModel userAuthentication);
    Task Logout();
    Task<string> RefreshToken();
}
