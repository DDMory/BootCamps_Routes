using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMinimalApi.dominio.ModelsViews
{
    public struct Home
    {
        public string Mensagem { get => "BEM VINDO À MINHA API DE VEICULOS -  MINIMAL API"; }
        public string Documentacao { get => "http://localhost:5233/swagger"; }
    }
}