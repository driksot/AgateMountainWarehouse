using AgateMountainWarehouse.Client.AuthProviders;
using AgateMountainWarehouse.Client.ViewModels;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace AgateMountainWarehouse.Client.HttpRepository;

public class AuthenticationService : IAuthenticationService
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;
    private readonly AuthenticationStateProvider _authStateProvider;
    private readonly ILocalStorageService _localStorage;

    public AuthenticationService(HttpClient httpClient, AuthenticationStateProvider authStateProvider, ILocalStorageService localStorage)
    {
        _httpClient = httpClient;
        _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        _authStateProvider = authStateProvider;
        _localStorage = localStorage;
    }

    public async Task<AuthResponseViewModel> Login(UserAuthenticationViewModel userAuthentication)
    {
        var content = JsonSerializer.Serialize(userAuthentication);
        var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

        var authResult = await _httpClient.PostAsync("api/accounts/login", bodyContent);
        var authContent = await authResult.Content.ReadAsStringAsync();
        var result = JsonSerializer.Deserialize<AuthResponseViewModel>(authContent, _options);

        if (!authResult.IsSuccessStatusCode)
            return result;

        await _localStorage.SetItemAsync("authToken", result.Token);
        await _localStorage.SetItemAsync("refreshToken", result.RefreshToken);
        ((AuthStateProvider)_authStateProvider).NotifyUserAuthentication(result.Token);
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", result.Token);

        return new AuthResponseViewModel { IsAuthSuccessful = true };
    }

    public async Task Logout()
    {
        await _localStorage.RemoveItemAsync("authToken");
        await _localStorage.RemoveItemAsync("refreshToken");
        ((AuthStateProvider)_authStateProvider).NotifyUserLogout();
        _httpClient.DefaultRequestHeaders.Authorization = null;
    }

    public async Task<string> RefreshToken()
    {
        var token = await _localStorage.GetItemAsync<string>("authToken");
        var refreshToken = await _localStorage.GetItemAsync<string>("refreshToken");

        var tokenDto = JsonSerializer.Serialize(new RefreshTokenViewModel { Token = token, RefreshToken = refreshToken });
        var bodyContent = new StringContent(tokenDto, Encoding.UTF8, "application/json");

        var refreshResult = await _httpClient.PostAsync("api/token/refresh", bodyContent);
        var refreshContent = await refreshResult.Content.ReadAsStringAsync();
        var result = JsonSerializer.Deserialize<AuthResponseViewModel>(refreshContent, _options);

        if (!refreshResult.IsSuccessStatusCode)
            throw new ApplicationException("Something went wrong during the refresh token action");

        await _localStorage.SetItemAsync("authToken", result.Token);
        await _localStorage.SetItemAsync("refreshToken", result.RefreshToken);

        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", result.Token);

        return result.Token;
    }

    public async Task<RegistrationResponseViewModel> RegisterUser(UserRegistrationViewModel userForRegistration)
    {
        var content = JsonSerializer.Serialize(userForRegistration);
        var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
        var registrationResult = await _httpClient.PostAsync("api/accounts/registration", bodyContent);
        var registrationContent = await registrationResult.Content.ReadAsStringAsync();
        if (!registrationResult.IsSuccessStatusCode)
        {
            var result = JsonSerializer.Deserialize<RegistrationResponseViewModel>(registrationContent, _options);
            return result;
        }
        return new RegistrationResponseViewModel { IsSuccessfulRegistration = true };
    }
}
