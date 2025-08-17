using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMinimalApi.dominio.Entidades;
using MyMinimalApi.dominio.Interfaces;
using MyMinimalApi.infraestrutura.db;

namespace MyMinimalApi.dominio.Servicos
{
    public class VeiculosServices : IVeiculosServices
    {
         private readonly DbContexto _contexto;
        public VeiculosServices(DbContexto contexto)
        {

            _contexto = contexto;
        }

        public void ApagarVeiculo(Veiculo veiculo)
        {
            _contexto.Veiculos.Remove(veiculo);
            _contexto.SaveChanges();
        }

        public void AtualizarVeiculo(Veiculo veiculo)
        {
            _contexto.Veiculos.Update(veiculo);
            _contexto.SaveChanges();
        }

        public Veiculo? BuscarPorId(int Id)
        {
            return _contexto.Veiculos.Where(veiculo => veiculo.Id == Id).FirstOrDefault();
        }

        public List<Veiculo> ListarVeiculos(int pagina = 1, string? nome = null, string? marca = null)
        {
            var query = _contexto.Veiculos.AsQueryable();

            if (!string.IsNullOrEmpty(nome))
            {
                query = query.Where(veiculo => EF.Functions.Like(veiculo.Nome.ToLower(), $"%{nome}%"));
                return query.ToList();
            }

            /*
            if (!string.IsNullOrEmpty(marca))
            {
                query = query.Where(veiculo => EF.Functions.Like(veiculo.Marca.ToLower(), $"%{marca}%"));
                return query.ToList();
            }
            */

            int ItensPorPagina = 10;

            query = query.Skip((pagina - 1) * ItensPorPagina).Take(ItensPorPagina);

            return query.ToList();
        }

        public void SalvarVeiculo(Veiculo veiculo)
        {
            _contexto.Veiculos.Add(veiculo);
            _contexto.SaveChanges();
        }
    }
}