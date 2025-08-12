using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstracao_Encapsulamento.models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Ola, me chamo {Nome}, tenho {Idade} anos e meu salario é {Salario}");
        }
    }
}