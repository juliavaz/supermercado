using Supermercado.Core.Domain.Interfaces;
using Supermercado.Core.Domain.Models;
using Supermercado.Core.Domain.Response;

namespace Supermercado.Core.Domain.Services
{
    public class ProdutoService : IProdutoService
    {
        public readonly ICategoriaRepository _categoriaRepository;
        public readonly IProdutoRepository _produtoRepository;

        public ProdutoService(ICategoriaRepository categoriaRepository, IProdutoRepository produtoRepository)
        {
            _categoriaRepository = categoriaRepository;
            _produtoRepository = produtoRepository;
        }

        public void Insert(ProdutoResponse produtoResponse)
        {
            var categoria = _categoriaRepository.FindByIdAsync(101);
            var produto = new Produto(produtoResponse.Nome, produtoResponse.QuantidadePacote, EnumUnidadeMedida.Unidade, categoria.Result);

            _produtoRepository.Insert(produto);

            _produtoRepository.SaveChanges();
        }
    }
}
