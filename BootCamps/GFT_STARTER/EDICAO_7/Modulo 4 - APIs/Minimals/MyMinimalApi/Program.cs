using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyMinimalApi.dominio.DTOs;
using MyMinimalApi.dominio.Interfaces;
using MyMinimalApi.dominio.Servicos;
using MyMinimalApi.infraestrutura.db;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<IAdministradorService, AdministradorService>();

builder.Services.AddDbContext<DbContexto>(
    options =>
    {
        options.UseMySql(

          builder.Configuration.GetConnectionString("mysql"),
          ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("mysql"))
       );
    }
);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapPost("/login", ([FromBody] LoginDTO loginDTO, IAdministradorService administradorService) =>
{
    if (administradorService.Login(loginDTO) != null)
        return Results.Ok("Login Sucesso!");
    else return Results.Unauthorized();

});

app.Run();