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

        public List<Administrador> ListarTodos(int? pagina = 1)
        {
             var query = _contexto.Administradores.AsQueryable();

            int ItensPorPagina = 10;

            if (pagina != null)
                query = query.Skip(((int)pagina - 1) * ItensPorPagina).Take(ItensPorPagina);

            return query.ToList();
        }

        public Administrador? Login(LoginDTO loginDTO)
        {
            var adm = _contexto.Administradores.Where(adm => adm.Email == loginDTO.Email && adm.Senha == loginDTO.Senha).FirstOrDefault();
            {
                return adm;
            }
        }

        public Administrador? BuscarPorId(int id)
        {
            return _contexto.Administradores.Where(adm => adm.Id == id).FirstOrDefault();
        }

        public Administrador SalvarAdministrador(Administrador administrador)
        {
            _contexto.Administradores.Add(administrador);
            _contexto.SaveChanges();

            return administrador;
        }
    }
}