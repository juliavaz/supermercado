using Supermercado.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Supermercado.Api.Domain.Repositories
{
    public interface ICategoriaRepository
    {
        Task<IEnumerable<Categoria>> ListAsync();
        Task AddAsync(Categoria categoria);
        Task<Categoria> FindByIdAsync(int id);
        void Update(Categoria categoria);
        void Remove(Categoria categoria);
    }
}
