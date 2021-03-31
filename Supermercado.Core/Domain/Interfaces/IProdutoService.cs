using Supermercado.Core.Domain.Requests;

namespace Supermercado.Core.Domain.Interfaces
{
    public interface IProdutoService
    {
        void Insert(ProdutoRequest produtoRequest);
    }
}
