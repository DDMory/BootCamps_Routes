using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyMinimalApi.dominio.DTOs;
using MyMinimalApi.dominio.Entidades;
using MyMinimalApi.dominio.Interfaces;
using MyMinimalApi.dominio.ModelsViews;
using MyMinimalApi.dominio.Servicos;
using MyMinimalApi.infraestrutura.db;


#region Builder
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<IAdministradorService, AdministradorService>();
builder.Services.AddScoped<IVeiculosServices, VeiculosServices>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
#endregion Builder


#region Home
app.MapGet("/", () => Results.Json(new Home()));
#endregion Home

#region Administradores
app.MapPost("/administradores/login", ([FromBody] LoginDTO loginDTO, IAdministradorService administradorService) =>
{
    if (administradorService.Login(loginDTO) != null)
        return Results.Ok("Login Sucesso!");
    else return Results.Unauthorized();

});
#endregion Administradores

#region Veiculos
#region Post
app.MapPost("/Veiculos", ([FromBody] VeiculoDTO veiculoDTO, IVeiculosServices VeiculosService) =>
{
    var veiculo = new Veiculo
    {
        Nome = veiculoDTO.Nome,
        Marca = veiculoDTO.Marca,
        Ano = veiculoDTO.Ano
    };

    VeiculosService.SalvarVeiculo(veiculo);

    return Results.Created($"/Veiculo/{veiculo.Id}", veiculo);
});
#endregion Post

#region Get
app.MapGet("/Veiculos", ([FromQuery] int? pagina, IVeiculosServices veiculosServices) =>
{
    var veiculos = veiculosServices.ListarVeiculos(pagina);
    return Results.Ok(veiculos);
});
#endregion Get

#endregion Veiculos


#region App
app.UseSwagger();
app.UseSwaggerUI();
app.Run();
#endregion App