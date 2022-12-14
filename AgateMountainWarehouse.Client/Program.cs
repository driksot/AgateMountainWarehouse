using AgateMountainWarehouse.Client;
using AgateMountainWarehouse.Client.AuthProviders;
using AgateMountainWarehouse.Client.HttpRepository;
using AgateMountainWarehouse.Client.Static;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Tewr.Blazor.FileReader;
using Toolbelt.Blazor.Extensions.DependencyInjection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
{
    builder.RootComponents.Add<App>("#app");
    builder.RootComponents.Add<HeadOutlet>("head::after");

    builder.Services.AddMudServices();

    builder.Services.AddScoped(sp => new HttpClient 
    { 
        BaseAddress = new Uri(APIEndpoints._serverBaseUrl) 
    }
    .EnableIntercept(sp));

    builder.Services.AddScoped<IProductHttpRepository, ProductHttpRepository>();
    builder.Services.AddScoped<IInventoryHttpRepository, InventoryHttpRepository>();
    builder.Services.AddScoped<IOrderHttpRepository, OrderHttpRepository>();
    builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();

    builder.Services.AddBlazoredLocalStorage();
    builder.Services.AddAuthorizationCore();
    builder.Services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();
    builder.Services.AddScoped<RefreshTokenService>();
    builder.Services.AddScoped<HttpInterceptorService>();

    builder.Services.AddHttpClientInterceptor();

    builder.Services.AddFileReaderService(o => o.UseWasmSharedBuffer = true);
}

await builder.Build().RunAsync();
