using Microsoft.AspNetCore.Mvc;
using Supermercado.Core.Domain.Models;
using Supermercado.Core.Domain.Services;

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
            var categorias = _categoriaService.ListAsync();
            return View(categorias.Result);
        }

        public IActionResult NovaCategoria()
        {
            var categoria = new Categoria()
            {
                Nome = "Material Esportivo",
            };

            _categoriaService.Insert(categoria);
            return View();
        }

        public IActionResult ListarCategorias()
        {
            var categorias = _categoriaService.ListAsync();
            return View(categorias.Result);
        }
    }
}
