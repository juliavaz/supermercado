using Microsoft.AspNetCore.Mvc;
using Supermercado.Core.Domain.Repositories;
using Supermercado.Core.Domain.Requests;
using Supermercado.Core.Domain.Services;

namespace Supermercado.Api.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoService produtoService, IProdutoRepository produtoRespository)
        {
            _produtoService = produtoService;
            _produtoRepository = produtoRespository;
        }

        public IActionResult Index()
        {
            var produtos = _produtoRepository.ListAsync();
            return View(produtos.Result);
        }

        public IActionResult NovoProduto()
        {
            return View(new ProdutoRequest());
        }

        public IActionResult SalvarProduto(ProdutoRequest produtoRequest)
        {
            _produtoService.Insert(produtoRequest);

            return RedirectToAction("Index");
        }

    }
}
