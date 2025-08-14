using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstratas_Interfaces.models
{
    public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {
            
        }
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Ola, me chamo{Nome}, tenho {Idade} anos e sou um professor, meu salario é {Salario}");
        }
    }
}