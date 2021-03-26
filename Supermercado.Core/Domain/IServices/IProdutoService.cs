using Supermercado.Core.Domain.Requests;

namespace Supermercado.Core.Domain.IServices
{
    public interface IProdutoService
    {
        void Insert(ProdutoRequest produtoRequest);
    }
}
