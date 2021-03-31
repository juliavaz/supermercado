using Microsoft.AspNetCore.Mvc;
using Supermercado.Core.Domain.Interfaces;
using Supermercado.Core.Domain.Response;

namespace Supermercado.Api.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        public IActionResult Index()
        {
            var categorias = _categoriaService.List();
            return View(categorias);
        }

        public IActionResult NovaCategoria()
        {
            return View(new CategoriaResponse());
        }

        public IActionResult SalvarCategoria(CategoriaResponse categoriaResponse)
        {
            _categoriaService.Insert(categoriaResponse);

            return RedirectToAction("Index");
        }

        public IActionResult ListarCategorias()
        {
            var categorias = _categoriaService.List();
            return View(categorias);
        }
    }
}
