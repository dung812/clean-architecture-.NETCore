using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SocialNetwork.Api.Configurations.Filter;
using SocialNetwork.Api.Configurations.Middleware;
using SocialNetwork.Api.Configurations.Swagger;
using SocialNetwork.Api.Configurations.Versioning;
using SocialNetwork.DataAccessLayer.Context;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
//builder.Host.AddAppConfigurations();
builder.Services.AddControllerWithCustomFilter(); //Add controller and global filter

builder.Services.AddCustomApiVersioning(); //Add versioning and custom config

builder.Services.AddSwaggerWithVersioning(); //Add Swagger to gen document with versioning


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SocialNetworkContext>(option =>
{
    option.UseSqlServer(
        configuration.GetConnectionString("local_ProductionManagement")
    );
});

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "AllowAll",
                      policy =>
                      {
                          policy.AllowAnyOrigin();
                          policy.AllowAnyMethod();
                          policy.AllowAnyHeader();
                      });
});

var app = builder.Build();

app.UseGlobalExceptionHandler(); //Use middleware to handle exception globally

if (!app.Environment.IsProduction())
{
    app.UseSwaggerUiWithVersioning(); //Use Swagger UI and some configs to make it work with versioning
}


app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();
