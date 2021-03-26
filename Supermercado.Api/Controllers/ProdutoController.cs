using Microsoft.AspNetCore.Mvc;
using Supermercado.Core.Domain.IRepositories;
using Supermercado.Core.Domain.IServices;
using Supermercado.Core.Domain.Requests;

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
            var request = new ProdutoRequest();
            request.Categorias = _categoriaService.List();

            return View(request);
        }

        public IActionResult SalvarProduto(ProdutoRequest produtoRequest)
        {
            _produtoService.Insert(produtoRequest);

            return RedirectToAction("Index");
        }

    }
}
