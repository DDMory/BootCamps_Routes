using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.models
{
    public class Pessoa
    {

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public string Nome { get; set; }
        public String Sobrenome { get; set; }
        public String NomeCompleto{
            get => $"{Nome} {Sobrenome}";
        }
    }
}