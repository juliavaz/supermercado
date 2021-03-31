using Supermercado.Core.Domain.Response;

namespace Supermercado.Core.Domain.Interfaces
{
    public interface IProdutoService
    {
        void Insert(ProdutoResponse produtoResponse);
    }
}
