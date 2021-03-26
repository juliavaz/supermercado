using Supermercado.Core.Domain.Models;
using Supermercado.Core.Domain.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Supermercado.Core.Domain.IServices
{
    public interface ICategoriaService
    {
        // retorna de forma assíncrona a enumeração de categorias.
        IList<CategoriaRequest> List();
        void Insert(Categoria categoria);
        void Insert(CategoriaRequest categoriaRequest);
    }
}
