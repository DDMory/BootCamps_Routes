using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using MyMinimalApi.dominio.DTOs;
using MyMinimalApi.dominio.Entidades;
using MyMinimalApi.dominio.Enuns;
using MyMinimalApi.dominio.Interfaces;
using MyMinimalApi.dominio.ModelsViews;
using MyMinimalApi.dominio.Servicos;
using MyMinimalApi.infraestrutura.db;


#region Builder
var builder = WebApplication.CreateBuilder(args);

var key = builder.Configuration.GetSection("Jwt").ToString();
if (string.IsNullOrEmpty(key)) key = "123456";


builder.Services.AddAuthentication(option =>
{
    option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(option =>
{
    
    option.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateLifetime = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)),
        ValidateIssuer = false,
        ValidateAudience = false

    };
});

builder.Services.AddAuthorization();

builder.Services.AddScoped<IAdministradorService, AdministradorService>();
builder.Services.AddScoped<IVeiculosServices, VeiculosServices>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    options => {
        options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
            Name = "Authorization",
            Type = SecuritySchemeType.Http,
            Scheme = "bearer",
            BearerFormat = "Jwt",
            In = ParameterLocation.Header,
            Description = "Insira o seu token assim: Bearer <Seu token>"
        });

        options.AddSecurityRequirement(new OpenApiSecurityRequirement
        {
            {

                new OpenApiSecurityScheme{
                    Reference = new OpenApiReference{
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                },

                new string[]{}

            }
        });
    }


);

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
app.MapGet("/", () => Results.Json(new Home())).AllowAnonymous().WithTags("Home");
#endregion Home

#region Administradores

string GerarTokenJwt(Administrador adm)
{
    if (string.IsNullOrEmpty(key)) return string.Empty;

    var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
    var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

    var claims = new List<Claim>()
    {
        new Claim("Email", adm.Email),
        new Claim("Perfil", adm.Perfil),
        new Claim(ClaimTypes.Role, adm.Perfil),
    };
    var token = new JwtSecurityToken
    (
        claims: claims,
        expires: DateTime.Now.AddDays(1),
        signingCredentials: credentials

    );

    return new JwtSecurityTokenHandler().WriteToken(token);
}

#region PostDefault
app.MapPost("/administradores/login", ([FromBody] LoginDTO loginDTO, IAdministradorService administradorService) =>
{
    var adm = administradorService.Login(loginDTO);
    if (adm != null) {
        string token = GerarTokenJwt(adm);
        return Results.Ok(new AdministradorLogado
        {
            Email = adm.Email,
            Perfil = adm.Perfil,
            Token = token
        });
    }
    else return Results.Unauthorized();

}).AllowAnonymous().WithTags("Administradores");
#endregion PostDefault

#region Post
app.MapPost("/administradores/", ([FromBody] AdministradorDTO administradorDTO, IAdministradorService administradorService) =>
{
    var validacoes = new ErrosValidate
    {
        Mensagens = new List<string>()
    };

    if (string.IsNullOrEmpty(administradorDTO.Email))
        validacoes.Mensagens.Add("Email não pode ficar em branco");
    if (string.IsNullOrEmpty(administradorDTO.Senha))
        validacoes.Mensagens.Add("Senha não pode ficar em branco");
    if (administradorDTO.Perfil == null)
        validacoes.Mensagens.Add("O perfil não pode ficar em branco");


    if (validacoes.Mensagens.Count() > 0)
        return Results.BadRequest(validacoes);


        var adm = new Administrador
        {
            Email = administradorDTO.Email,
            Senha = administradorDTO.Senha,
            Perfil = administradorDTO.Perfil.ToString() ?? Perfil.Editor.ToString()
        };

        administradorService.SalvarAdministrador(adm);

    return Results.Created($"Administrador/{adm.Id}", adm);
}).RequireAuthorization().RequireAuthorization(new AuthorizeAttribute { Roles = "Adm" }).WithTags("Administradores");
#endregion Post

#region GetAll

app.MapGet("/administradores", ([FromQuery] int? pagina, IAdministradorService administradorService) =>
{
    var adms = new List<AdministradorModelView>();
    var administradores = administradorService.ListarTodos(pagina);

    foreach (var administrador in administradores)
    {
        adms.Add(new AdministradorModelView
        {
            Id = administrador.Id,
            Email = administrador.Email,
            Perfil = administrador.Perfil
        });
    }

    return Results.Ok(adms);

}).
RequireAuthorization().RequireAuthorization(new AuthorizeAttribute { Roles = "Adm" }).WithTags("Administradores");

#endregion GetAll

#region GetById
app.MapGet("/administradores/{Id}", ([FromRoute] int Id, IAdministradorService administradorService) =>
{
    var adm = administradorService.BuscarPorId(Id);

    if (adm == null) return Results.NotFound();

    return Results.Ok(new AdministradorModelView
        {
            Id = adm.Id,
            Email = adm.Email,
            Perfil = adm.Perfil
        });;
}).RequireAuthorization().RequireAuthorization(new AuthorizeAttribute { Roles = "Adm" }).WithTags("Administradores");
#endregion GetById

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
}).RequireAuthorization().
RequireAuthorization(new AuthorizeAttribute { Roles = "Adm" }).
RequireAuthorization(new AuthorizeAttribute { Roles = "Editor" }).WithTags("Veiculos");

#endregion Post

#region Gets
#region GetAll
app.MapGet("/Veiculos", ([FromQuery] int? pagina, IVeiculosServices veiculosServices) =>
{
    var veiculos = veiculosServices.ListarVeiculos(pagina);
    return Results.Ok(veiculos);
}).RequireAuthorization().WithTags("Veiculos");
#endregion GetAll

#region GetById
app.MapGet("/Veiculos/{Id}", ([FromRoute] int Id, IVeiculosServices veiculosServices) =>
{
    var veiculo = veiculosServices.BuscarPorId(Id);

    if (veiculo == null) return Results.NotFound();

    return Results.Ok(veiculo);
}).RequireAuthorization().WithTags("Veiculos");
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
}).RequireAuthorization().RequireAuthorization(new AuthorizeAttribute { Roles = "Adm" }).WithTags("Veiculos");
#endregion Put

#region Delete
app.MapDelete("/Veiculos/{Id}", ([FromRoute] int Id,IVeiculosServices veiculosServices) =>
{
    var veiculo = veiculosServices.BuscarPorId(Id);

    if (veiculo == null) return Results.NotFound();

    veiculosServices.ApagarVeiculo(veiculo);

    return Results.NoContent();
}).RequireAuthorization().RequireAuthorization(new AuthorizeAttribute { Roles = "Adm" }).WithTags("Veiculos");
#endregion Delete

#endregion Veiculos

#region App
app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthentication();
app.UseAuthorization();

app.Run();
#endregion App