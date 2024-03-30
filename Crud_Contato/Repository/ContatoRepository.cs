using Crud_Contato.Interfaces;
using Crud_Contato.Models;
using System.Threading.Tasks;

namespace Crud_Contato.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly BancoDeDados _context;

        public ContatoRepository(BancoDeDados context)
        {
            _context = context;
        }

        public async Task Create(Contato contato) 
        {
            _context.Add(contato);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Contato contato)
        {
            _context.Update(contato);
            await _context.SaveChangesAsync();
        }
        
        public async Task Remove(Contato contato)
        {
            _context.Contatos.Remove(contato);
            await _context.SaveChangesAsync();
        }
    }
}
