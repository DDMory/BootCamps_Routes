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
app.MapGet("/", () => Results.Json(new Home())).WithTags("Home");
#endregion Home

#region Administradores
app.MapPost("/administradores/login", ([FromBody] LoginDTO loginDTO, IAdministradorService administradorService) =>
{
    if (administradorService.Login(loginDTO) != null)
        return Results.Ok("Login Sucesso!");
    else return Results.Unauthorized();

}).WithTags("Administradores");
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
}).WithTags("Veiculos");
#endregion Post

#region Gets
#region GetAll
app.MapGet("/Veiculos", ([FromQuery] int? pagina, IVeiculosServices veiculosServices) =>
{
    var veiculos = veiculosServices.ListarVeiculos(pagina);
    return Results.Ok(veiculos);
}).WithTags("Veiculos");
#endregion GetAll

#region GetById
app.MapGet("/Veiculos/{Id}", ([FromRoute] int Id, IVeiculosServices veiculosServices) =>
{
    var veiculo = veiculosServices.BuscarPorId(Id);

    if (veiculo == null) return Results.NotFound();

    return Results.Ok(veiculo);
}).WithTags("Veiculos");
#endregion GetById
#endregion Gets

#endregion Veiculos


#region App
app.UseSwagger();
app.UseSwaggerUI();
app.Run();
#endregion App