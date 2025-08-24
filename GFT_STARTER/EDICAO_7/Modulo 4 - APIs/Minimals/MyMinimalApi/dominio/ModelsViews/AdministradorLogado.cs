using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMinimalApi.dominio.ModelsViews
{
    public class AdministradorLogado
    {
        public string Email { get; set; } = default!;
        public string Perfil { get; set; } = default!;
        public string Token { get; set; } = default!;
        
    }
}