using System.Runtime.InteropServices;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => Results.Ok(new
{
    application = "AzurePortfolio.Api",
    message = "ASP.NET Core running successfully",
    environment = app.Environment.EnvironmentName
}));

app.MapGet("/health", () => Results.Ok(new
{
    status = "Healthy",
    timestampUtc = DateTimeOffset.UtcNow
}));

app.MapGet("/api/info", () => Results.Ok(new
{
    application = "AzurePortfolio.Api",
    version = "1.0.0",
    framework = RuntimeInformation.FrameworkDescription,
    operatingSystem = RuntimeInformation.OSDescription,
    environment = app.Environment.EnvironmentName
}));

app.Run();
