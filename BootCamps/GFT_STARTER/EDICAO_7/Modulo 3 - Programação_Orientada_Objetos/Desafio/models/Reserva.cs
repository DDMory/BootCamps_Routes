using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.models
{
    public class Reserva
    {

        public Reserva(){}
        public Reserva(int diasReservados){
            DiasReservados = diasReservados;
        }
        public List<Pessoa> Hospedes;
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
                Hospedes = hospedes;
            else throw new Exception("Quantidade de pessoas excede a capacidade da Suite!!");
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorFinal = DiasReservados >= 10 ? (DiasReservados * Suite.ValorDiaria) * 0.9M : DiasReservados * Suite.ValorDiaria;
            return valorFinal;
        }
            
    }
}