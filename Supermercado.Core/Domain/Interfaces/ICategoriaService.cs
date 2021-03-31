using Supermercado.Core.Domain.Models;
using Supermercado.Core.Domain.Requests;
using System.Collections.Generic;

namespace Supermercado.Core.Domain.Interfaces
{
    public interface ICategoriaService
    {
        // retorna de forma assíncrona a enumeração de categorias.
        IList<CategoriaRequest> List();
        void Insert(Categoria categoria);
        void Insert(CategoriaRequest categoriaRequest);
    }
}
