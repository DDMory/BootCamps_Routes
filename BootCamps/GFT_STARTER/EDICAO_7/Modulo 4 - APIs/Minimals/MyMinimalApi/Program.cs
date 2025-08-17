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

ErrosValidate validarDTO(VeiculoDTO veiculoDTO)
{
    var validacoes = new ErrosValidate
    {
        Mensagens  = new List<string>()
    };

    if (string.IsNullOrEmpty(veiculoDTO.Nome))
        validacoes.Mensagens.Add("O nome não pode ficar em branco!");
    if (string.IsNullOrEmpty(veiculoDTO.Marca))
        validacoes.Mensagens.Add("O marca não pode ficar em branco!");
    if (veiculoDTO.Ano < 1950)
        validacoes.Mensagens.Add("Veiculo antigo! [Min > 1950]");

    return validacoes;
}

#region Post
app.MapPost("/Veiculos", ([FromBody] VeiculoDTO veiculoDTO, IVeiculosServices VeiculosService) =>
{

    
    var validacoes = validarDTO(veiculoDTO);
    if (validacoes.Mensagens.Count() > 0)
        return Results.BadRequest(validacoes);

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

#region Put
app.MapPut("/Veiculos/{Id}", ([FromRoute] int Id, VeiculoDTO veiculoDTO,IVeiculosServices veiculosServices) =>
{
    var veiculo = veiculosServices.BuscarPorId(Id);
    if (veiculo == null) return Results.NotFound();

    var validacoes = validarDTO(veiculoDTO);
    if (validacoes.Mensagens.Count() > 0)
        return Results.BadRequest(validacoes);

    

    veiculo.Nome = veiculoDTO.Nome;
    veiculo.Marca = veiculoDTO.Marca;
    veiculo.Ano = veiculoDTO.Ano;

    veiculosServices.AtualizarVeiculo(veiculo);

    return Results.Ok(veiculo);
}).WithTags("Veiculos");
#endregion Put

#region Delete
app.MapDelete("/Veiculos/{Id}", ([FromRoute] int Id,IVeiculosServices veiculosServices) =>
{
    var veiculo = veiculosServices.BuscarPorId(Id);

    if (veiculo == null) return Results.NotFound();

    veiculosServices.ApagarVeiculo(veiculo);

    return Results.NoContent();
}).WithTags("Veiculos");
#endregion Delete

#endregion Veiculos


#region App
app.UseSwagger();
app.UseSwaggerUI();
app.Run();
#endregion App