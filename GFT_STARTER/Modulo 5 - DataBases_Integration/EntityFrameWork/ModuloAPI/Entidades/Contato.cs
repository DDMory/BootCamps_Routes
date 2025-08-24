using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloAPI.Entidades
{
    public class Contato
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool StatusActive { get; set; }
    }
}