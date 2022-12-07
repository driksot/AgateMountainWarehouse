using AgateMountainWarehouse.Client;
using AgateMountainWarehouse.Client.AuthProviders;
using AgateMountainWarehouse.Client.HttpRepository;
using AgateMountainWarehouse.Client.Static;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Tewr.Blazor.FileReader;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
{
    builder.RootComponents.Add<App>("#app");
    builder.RootComponents.Add<HeadOutlet>("head::after");

    builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(APIEndpoints._serverBaseUrl) });
    builder.Services.AddScoped<IProductHttpRepository, ProductHttpRepository>();
    builder.Services.AddScoped<IInventoryHttpRepository, InventoryHttpRepository>();
    builder.Services.AddScoped<IOrderHttpRepository, OrderHttpRepository>();
    builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();

    builder.Services.AddScoped<AuthenticationStateProvider, TestAuthStateProvider>();

    builder.Services.AddAuthorizationCore();
    builder.Services.AddFileReaderService(o => o.UseWasmSharedBuffer = true);
}

await builder.Build().RunAsync();
