using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

// Configure logging
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// Add services to the container
builder.Services.AddControllers();

var app = builder.Build();

// Configure middleware based on environment
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error"); // Redirect to a generic error page in production
    app.UseHsts(); // Enforce strict transport security
}

// Enable HTTPS redirection (optional for EC2 if behind a load balancer with SSL termination)
app.UseHttpsRedirection();

// Enable routing
app.UseRouting();

// Add authorization middleware (if applicable)
app.UseAuthorization();

// Default route
app.MapGet("/", () => "Hello World!");

// Map API controllers
app.MapControllers();

// Run the app
app.Run();