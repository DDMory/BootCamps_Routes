using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyMinimalApi.dominio.Entidades
{
    public class Administrador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = default;

        [Required]
        [StringLength(245)]
        public string Email { get; set; } = default;
        [StringLength(50)]
        public string Senha { get; set; } = default;
        [StringLength(10)]
        public string Perfil { get; set; } = default;
    }
}