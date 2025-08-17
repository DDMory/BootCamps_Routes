using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyMinimalApi.dominio.DTOs;
using MyMinimalApi.dominio.Entidades;
using MyMinimalApi.dominio.Interfaces;
using MyMinimalApi.infraestrutura.db;

namespace MyMinimalApi.dominio.Servicos
{
    public class AdministradorService : IAdministradorService
    {
        private readonly DbContexto _contexto;
        public AdministradorService(DbContexto contexto)
        {

            _contexto = contexto;
        }
        public Administrador? Login(LoginDTO loginDTO)
        {
            var adm = _contexto.Administradores.Where(adm => adm.Email == loginDTO.Email && adm.Senha == loginDTO.Senha).FirstOrDefault();
            {
                return adm;
            }
        }
    }
}