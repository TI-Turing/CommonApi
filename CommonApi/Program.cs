using CommonApi;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

var builder = FunctionsApplication.CreateBuilder(args);

builder.ConfigureFunctionsWebApplication();

builder.Services
    .AddApplicationInsightsTelemetryWorkerService()
    .ConfigureFunctionsApplicationInsights();

// Configure connection string from environment variables
var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING") ?? "Server=.;Database=CommonApi;Integrated Security=True;TrustServerCertificate=True;Encrypt=True;";

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

var host = builder.Build();

// Apply migrations
MigrationInitializer.ApplyMigrations(host.Services);

host.Run();
