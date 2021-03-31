using Microsoft.AspNetCore.Mvc;
using Supermercado.Core.Domain.Interfaces;
using Supermercado.Core.Domain.Response;

namespace Supermercado.Api.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;
        private readonly IProdutoRepository _produtoRepository;
        private readonly ICategoriaService _categoriaService;

        public ProdutoController(IProdutoService produtoService, IProdutoRepository produtoRespository, ICategoriaService categoriaService)
        {
            _produtoService = produtoService;
            _produtoRepository = produtoRespository;
            _categoriaService = categoriaService;
        }

        public IActionResult Index()
        {
            var produtos = _produtoRepository.ListAsync();
            return View(produtos.Result);
        }

        public IActionResult NovoProduto()
        {
            var response = new ProdutoResponse();
            response.Categorias = _categoriaService.List();

            return View(response);
        }

        public IActionResult SalvarProduto(ProdutoResponse produtoResponse)
        {
            _produtoService.Insert(produtoResponse);

            return RedirectToAction("Index");
        }

    }
}
