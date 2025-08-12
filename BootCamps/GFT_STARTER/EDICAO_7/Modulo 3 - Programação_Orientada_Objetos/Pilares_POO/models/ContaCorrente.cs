using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstracao_Encapsulamento.models
{
    public class ContaCorrente
    {

        public ContaCorrente(int numeroConta, decimal saldo)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
        }
        public int NumeroConta { get; set; }
        private decimal Saldo { get; set; }

        public void Sacar(decimal valor)
        {
            if (Saldo >= valor)
                Saldo -= valor;
            else throw new Exception("Valor a sacar excede o Saldo em conta");
        }
        public void ExibirSaldo()
        {
            Console.WriteLine(Saldo);
        }
    }
}