//var builder = WebApplication.CreateBuilder(args);
using Talonario.Api.Extensions;
//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();

//builder.Services.AddSwaggerGen();

using Talonario.Api.Factories;

var app = WebApplicationBuilderFactory.CreateWebApplication(args);

// Configure the HTTP request pipeline.

app.UseCors();
app.AddSwagger();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
