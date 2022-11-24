using AgateMountainWarehouse.Client;
using AgateMountainWarehouse.Client.HttpRepository;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
{
    builder.RootComponents.Add<App>("#app");
    builder.RootComponents.Add<HeadOutlet>("head::after");

    builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7252/api/") });
    builder.Services.AddScoped<IProductHttpRepository, ProductHttpRepository>();
}

await builder.Build().RunAsync();
