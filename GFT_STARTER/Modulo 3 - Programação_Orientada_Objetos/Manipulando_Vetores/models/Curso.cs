using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manipulando_Vetores.models
{
    public class Curso
    {
        private string _nome;
        public string nome
        {
            get => _nome;
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Nome do curso não pode ser vazio!!\n");
                }

                _nome = value;
            }
        }
        public List<Pessoa> alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            alunos.Add(aluno);
        }

        public void QuantidadeAlunosMatriculados()
        {
            Console.WriteLine($"Quantidade de alunos no curso de {_nome}: {alunos.Count()}");
        }

        public void RemoverAluno(Pessoa aluno)
        {
            alunos.Remove(aluno);
        }
        public void ListarAlunos()
        {
            Console.WriteLine(" - - - Listando alunos - - -");

            int contador = 0;
            foreach (Pessoa aluno in alunos)
            {
                Console.WriteLine($"Aluno {contador + 1}: {aluno.nomeCompleto}");
                contador++;
            }

            //Outra maneira
            /*
                int contador = 0;
                Console.WriteLine("Alunos do curso de " + nome);
                foreach (Pessoa aluno in alunos)
                {
                    string texto = "Aluno " + (contador++) + $": {aluno.nomeCompleto}";
                    Console.WriteLine($"Aluno {contador + 1}: {aluno.nomeCompleto}");
                    contador++;
                }
            */
        }
    }
}