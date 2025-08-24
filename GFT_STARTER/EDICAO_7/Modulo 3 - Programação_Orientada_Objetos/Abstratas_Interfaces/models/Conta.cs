using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstratas_Interfaces.models
{
    /*
        CLASSE ABSTRATA
    */
    public abstract class Conta
    {
        protected decimal Saldo { get; set; }

        public abstract void Creditar(decimal valor);
        public void ExibirSaldo()
        {
            Console.WriteLine($" O seu saldo é {Saldo:C}");
        }


    }
}