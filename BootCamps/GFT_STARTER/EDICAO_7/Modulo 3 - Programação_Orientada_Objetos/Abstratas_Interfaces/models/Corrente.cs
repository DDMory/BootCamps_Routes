using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstratas_Interfaces.models
{
    public class Corrente : Conta
    {

        public override void Creditar(decimal valor)
        {
            Saldo += valor;
        }
    }
}