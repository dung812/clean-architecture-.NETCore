using SocialNetwork.Api.Configurations.Filter;
using SocialNetwork.Api.Configurations.Swagger;
using SocialNetwork.Api.Configurations.Versioning;

var builder = WebApplication.CreateBuilder(args);
//builder.Host.AddAppConfigurations();
builder.Services.AddControllerWithCustomFilter(); //Add controller and global filter


builder.Services.AddCustomApiVersioning(); //Add versioning and custom config

builder.Services.AddSwaggerWithVersioning(); //Add Swagger to gen document with versioning


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (!app.Environment.IsProduction())
{
    app.UseSwaggerUiWithVersioning(); //Use Swagger UI and some configs to make it work with versioning
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
