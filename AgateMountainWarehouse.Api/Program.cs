using AgateMountainWarehouse.Api;
using AgateMountainWarehouse.Api.Middleware;
using AgateMountainWarehouse.Application;
using AgateMountainWarehouse.Infrastructure;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddPresentation(builder.Configuration)
        .AddApplication()
        .AddInfrastructure(builder.Configuration);
}

var app = builder.Build();
{
    app.UseMiddleware<ExceptionMiddleware>();

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();
    app.UseCors("CorsPolicy");
    app.UseStaticFiles();
    app.UseStaticFiles(new StaticFileOptions()
    {
        FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"StaticFiles")),
        RequestPath = new PathString("/StaticFiles")
    });
    app.UseAuthentication();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}
