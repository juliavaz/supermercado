using Microsoft.AspNetCore.Mvc;
using Supermercado.Core.Domain.Interfaces;
using Supermercado.Core.Domain.Requests;

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
            return View(new CategoriaRequest());
        }

        public IActionResult SalvarCategoria(CategoriaRequest categoriaRequest)
        {
            _categoriaService.Insert(categoriaRequest);

            return RedirectToAction("Index");
        }

        public IActionResult ListarCategorias()
        {
            var categorias = _categoriaService.List();
            return View(categorias);
        }
    }
}
