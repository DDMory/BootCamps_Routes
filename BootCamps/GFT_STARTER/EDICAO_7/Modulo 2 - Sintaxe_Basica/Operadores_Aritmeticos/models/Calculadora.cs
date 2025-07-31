using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Operadores_Aritmeticos.models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = " + (x + y));
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = " + (x - y));
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = " + (x * y));
        }

        public void Dividir(int x, int y)
        {
            if (y == 0)
                Console.WriteLine("Divisão por zero!!!");
            else Console.WriteLine($"{x} / {y} = " + (x / y));
        }

        public void Potencia(int x, int y)
        {

            Console.WriteLine($"{x}^{y} = " + Math.Pow(x, y));

        }

        public void Seno(double angulo)
        {

            double radiano = ((angulo * Math.PI) / 180);
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno do angulo {angulo} é {Math.Round(seno, 4)}");

        }

        public void Cosseno(double angulo)
        {

            double radiano = ((angulo * Math.PI) / 180);
            double cos = Math.Cos(radiano);
            Console.WriteLine($"Seno do angulo {angulo} é {Math.Round(cos, 4)}");

        }

        public void Tangente(double angulo)
        {

            double radiano = ((angulo * Math.PI) / 180);
            double tan = Math.Tan(radiano);
            Console.WriteLine($"Seno do angulo {angulo} é {Math.Round(tan, 4)}");

        }
        
        public void RaizQuadrada(int x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} é igual a {raiz}");
            
        }
    }
}