using AgateMountainWarehouse.Client;
using AgateMountainWarehouse.Client.HttpRepository;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Tewr.Blazor.FileReader;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
{
    builder.RootComponents.Add<App>("#app");
    builder.RootComponents.Add<HeadOutlet>("head::after");

    builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7252/api/") });
    builder.Services.AddScoped<IProductHttpRepository, ProductHttpRepository>();
    builder.Services.AddScoped<IInventoryHttpRepository, InventoryHttpRepository>();

    builder.Services.AddFileReaderService(o => o.UseWasmSharedBuffer = true);
}

await builder.Build().RunAsync();
