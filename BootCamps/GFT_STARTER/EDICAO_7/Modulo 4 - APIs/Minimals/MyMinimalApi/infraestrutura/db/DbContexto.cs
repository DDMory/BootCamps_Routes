using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMinimalApi.dominio.Entidades;

namespace MyMinimalApi.infraestrutura.db
{
    public class DbContexto : DbContext
    {
        private readonly IConfiguration _configuracaoAppSettings;
        public DbContexto(IConfiguration configuracaoAppSettings)
        {
            _configuracaoAppSettings = configuracaoAppSettings;
        }
        public DbSet<Administrador> Administradores { get; set; } = default;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var stringConexao = _configuracaoAppSettings.GetConnectionString("mysql")?.ToString();

            if (!optionsBuilder.IsConfigured){
                if (!string.IsNullOrEmpty(stringConexao))
                {

                    optionsBuilder.UseMySql(
                        stringConexao,
                        ServerVersion.AutoDetect(stringConexao)
                    );
                }
            
            }
        }
    }
}