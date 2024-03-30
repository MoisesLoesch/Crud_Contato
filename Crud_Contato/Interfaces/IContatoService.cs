using Crud_Contato.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Crud_Contato.Interfaces
{
    public interface IContatoService
    {
        Task Create(Contato contato);
        Task Update(Contato contato);
        Task Remove(Contato contato);
    }
}
