using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyMinimalApi.dominio.Enuns;

namespace MyMinimalApi.dominio.DTOs
{
    public class AdministradorDTO
    {

        public string Email { get; set; } = default!;

        public string Senha { get; set; } = default!;
        public Perfil? Perfil { get; set; } = default;
    }
} 