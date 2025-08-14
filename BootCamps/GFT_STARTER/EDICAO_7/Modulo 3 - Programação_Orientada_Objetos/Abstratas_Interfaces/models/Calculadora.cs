using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abstratas_Interfaces.Interfaces;

namespace Abstratas_Interfaces.models
{
    public class Calculadora : ICalculadora
    {
        public int Dividir(int n1, int n2)
        {
            if (n2 > 0 || n1 < 0)
                return n1 / n2;
            else throw new Exception("Numerador não pode ser zero!!");
        }

        public int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }

        public int Somar(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}