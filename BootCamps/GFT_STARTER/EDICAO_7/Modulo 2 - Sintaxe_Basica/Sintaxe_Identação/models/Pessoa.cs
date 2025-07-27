using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sintaxe_Identação.models
{
    public class Pessoa
    {
        public String? Nome { get; set; }
        public int Idade { get; set; }

        /**/
        public void Apresentar()
        {
            Console.WriteLine($"Olá! Meu come é {Nome}, e tenho {Idade} anos.\n\n");   
        }
    }
}