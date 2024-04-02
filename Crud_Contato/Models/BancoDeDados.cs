using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

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
        public DbSet<AdminUser> AdminUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) 
        {
            if (!builder.IsConfigured)
            {
                IConfigurationRoot config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var serverVersion = new MySqlServerVersion(new Version(8, 0, 26));
                var conexao = _configuration["ConnectionStrings:MariaDB"].ToString();
                builder.UseMySql(connectionString: conexao, serverVersion: serverVersion, mySqlOptions => mySqlOptions.EnableRetryOnFailure());
            }

            //var serverVersion = new MySqlServerVersion(new Version(8, 0, 26));
            //var conexao = _configuration["ConnectionStrings:MariaDB"].ToString();
            //builder.UseMySql(connectionString: conexao, serverVersion: serverVersion);
        }
    }
}
