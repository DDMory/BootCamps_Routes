using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyMinimalApi.dominio.Entidades;

namespace MyMinimalApi.dominio.Interfaces
{
    public interface IVeiculosServices
    {
        List<Veiculo> ListarVeiculos(int pagina = 1, string? nome = null, string? marca = null);
        Veiculo? BuscarPorId(int Id);
        void SalvarVeiculo(Veiculo veiculo);
        void AtualizarVeiculo(Veiculo veiculo);

        void ApagarVeiculo(Veiculo veiculo);
    }
}