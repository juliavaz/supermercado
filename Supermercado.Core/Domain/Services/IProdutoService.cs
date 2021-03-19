using Supermercado.Core.Domain.Requests;

namespace Supermercado.Core.Domain.Services
{
    public interface IProdutoService
    {
        void Insert(ProdutoRequest produtoRequest);
    }
}
