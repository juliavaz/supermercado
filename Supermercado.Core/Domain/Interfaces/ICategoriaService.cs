using Supermercado.Core.Domain.Models;
using Supermercado.Core.Domain.Response;
using System.Collections.Generic;

namespace Supermercado.Core.Domain.Interfaces
{
    public interface ICategoriaService
    {
        // retorna de forma assíncrona a enumeração de categorias.
        IList<CategoriaResponse> List();
        void Insert(Categoria categoria);
        void Insert(CategoriaResponse categoriaResponse);
    }
}
