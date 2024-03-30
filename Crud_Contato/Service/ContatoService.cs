using Crud_Contato.Interfaces;
using Crud_Contato.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace Crud_Contato.Service
{
    public class ContatoService : IContatoService
    {
        private readonly IConfiguration _config;
        private readonly IContatoRepository _contato;
        public ContatoService(IConfiguration config, IContatoRepository contato)
        {
            _config = config;
            _contato = contato;
        }

        public async Task Create(Contato contato) => await _contato.Create(contato);
        public async Task Update(Contato contato) => await _contato.Update(contato);
        public async Task Remove(Contato contato) => await _contato.Remove(contato);

    }
}
