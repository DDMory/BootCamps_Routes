using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace Manipulando_Vetores.models
{
    public class Pessoa
    {

        public Pessoa(string Nome, string SobreNome, int Idade)
        {
            this.nome = Nome;
            this.sobreNome = SobreNome;
            this.idade = idade;

        }
        public Pessoa(){}

        private string _nome;
        public string nome{

            get => _nome.ToUpper(); 
            
            
            set{
                if (value == "" || value.Length < 3)
                {
                    throw new ArgumentException("O nome não pode ser vazio e nem possuir menos de 3 caracteres");
                }

                _nome = value;
            }
        }

        public string sobreNome{ get; set; }

        public string nomeCompleto => $"{nome} {sobreNome}".ToUpper();
        private int _idade;
        public int idade
        {
            get => _idade;
            set
            {
                if (value < 0 || value > 110)
                    throw new ArgumentException("Idade invalida!!");

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($" Prazer! eu me chamo {nomeCompleto} e tenho {idade} anos!!");
        }
    }
}