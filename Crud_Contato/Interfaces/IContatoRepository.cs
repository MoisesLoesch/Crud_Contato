using Crud_Contato.Models;
using System.Threading.Tasks;

namespace Crud_Contato.Interfaces
{
    public interface IContatoRepository
    {
        Task Create(Contato contato);
        Task Update(Contato contato);
        Task Remove(Contato contato);
    }
}
