using Supermercado.Core.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Supermercado.Core.Domain.Repositories
{
    public interface IProdutoRepository
    {
        void Insert(Produto produto);
        void SaveChanges();
        Task<IEnumerable<Produto>> ListAsync();
    }
}
