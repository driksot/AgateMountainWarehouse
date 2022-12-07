using AgateMountainWarehouse.Client.ViewModels;
using System.Text;
using System.Text.Json;

namespace AgateMountainWarehouse.Client.HttpRepository;

public class AuthenticationService : IAuthenticationService
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public AuthenticationService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }

    public async Task<RegistrationResponseViewModel> RegisterUser(UserRegistrationViewModel userForRegistration)
    {
        var content = JsonSerializer.Serialize(userForRegistration);
        var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
        var registrationResult = await _httpClient.PostAsync("accounts/registration", bodyContent);
        var registrationContent = await registrationResult.Content.ReadAsStringAsync();
        if (!registrationResult.IsSuccessStatusCode)
        {
            var result = JsonSerializer.Deserialize<RegistrationResponseViewModel>(registrationContent, _options);
            return result;
        }
        return new RegistrationResponseViewModel { IsSuccessfulRegistration = true };
    }
}
