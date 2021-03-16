using Supermercado.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Supermercado.Api.Domain.Services
{
    public interface ICategoriaService
    {
        // retorna de forma assíncrona a enumeração de categorias.
        Task<IEnumerable<Categoria>> ListAsync();
    }
}
