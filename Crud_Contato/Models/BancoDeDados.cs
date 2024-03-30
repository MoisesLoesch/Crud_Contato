using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace Crud_Contato.Models
{
    public class BancoDeDados : DbContext
    {
        private readonly IConfiguration _configuration;
        public BancoDeDados(IConfiguration config)
        {
            _configuration = config;
        }

        public DbSet<Contato> Contatos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) 
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 26));
            var conexao = _configuration["ConnectionStrings:MariaDB"].ToString();
            builder.UseMySql(connectionString: conexao, serverVersion: serverVersion);
        }
    }
}
