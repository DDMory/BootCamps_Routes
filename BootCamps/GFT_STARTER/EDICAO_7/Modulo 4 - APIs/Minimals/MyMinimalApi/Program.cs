using Microsoft.EntityFrameworkCore;
using MyMinimalApi.dominio.DTOs;
using MyMinimalApi.infraestrutura.db;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddDbContext<DbContexto>(
    options =>
    {
        options.UseMySql(

          builder.Configuration.GetConnectionString("mysql"),
          ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("mysql"))
       );
    }
);


app.MapGet("/", () => "Hello World!");
app.MapPost("/login", (LoginDTO loginDTO) =>
{
    if ((loginDTO.Email == "adm@teste.com") && (loginDTO.Senha == "123432"))
        return Results.Ok("Login Sucesso!");
    else return Results.Unauthorized();

});

app.Run();