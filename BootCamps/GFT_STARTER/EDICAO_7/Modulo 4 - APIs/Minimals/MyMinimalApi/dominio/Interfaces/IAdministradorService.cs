using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyMinimalApi.dominio.DTOs;
using MyMinimalApi.dominio.Entidades;

namespace MyMinimalApi.dominio.Interfaces
{
    public interface IAdministradorService
    {
        //List<Administrador> Login(LoginDTO loginDTO);
        Administrador? Login(LoginDTO loginDTO);
        Administrador SalvarAdministrador(Administrador administrador);
        List<Administrador> ListarTodos(int? pagina);

        Administrador? BuscarPorId(int id);
    }
}