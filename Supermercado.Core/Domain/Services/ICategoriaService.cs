using Supermercado.Core.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Supermercado.Core.Domain.Services
{
    public interface ICategoriaService
    {
        // retorna de forma assíncrona a enumeração de categorias.
        Task<IEnumerable<Categoria>> ListAsync();
        void Insert(Categoria categoria);
    }
}
