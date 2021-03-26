using Supermercado.Core.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Supermercado.Core.Domain.IRepositories
{
    public interface ICategoriaRepository
    {
        Task<IEnumerable<Categoria>> ListAsync();
        Task AddAsync(Categoria categoria);
        Task<Categoria> FindByIdAsync(int id);
        void Insert(Categoria categoria);
        void Update(Categoria categoria);
        void Remove(Categoria categoria);
    }
}
