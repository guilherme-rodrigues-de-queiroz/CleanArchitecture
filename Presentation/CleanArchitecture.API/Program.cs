using Scalar.AspNetCore;
using CleanArchitecture.Persistence.Context;
using CleanArchitecture.Persistence;
using CleanArchitecture.Application.Services;
using CleanArchitecture.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigurePersistenceApp(builder.Configuration);
builder.Services.ConfigureApplicationApp();
builder.Services.ConfigureCorsPolicy();

builder.Services.AddControllers();

builder.Services.AddOpenApi();

var app = builder.Build();

CreateDatabase(app);

app.MapOpenApi();
app.MapScalarApiReference();

app.UseCors();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

static void CreateDatabase(WebApplication app)
{
    var serviceScope = app.Services.CreateScope();
    var dataContext = serviceScope.ServiceProvider.GetService<AppDbContext>();
    dataContext?.Database.EnsureCreated();
}