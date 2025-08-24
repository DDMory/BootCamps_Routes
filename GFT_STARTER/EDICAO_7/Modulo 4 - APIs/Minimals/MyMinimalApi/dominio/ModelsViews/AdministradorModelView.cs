using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyMinimalApi.dominio.Enuns;

namespace MyMinimalApi.dominio.ModelsViews
{
    public record AdministradorModelView
    {
        public int Id { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Perfil { get; set; } = default!;
    }
}