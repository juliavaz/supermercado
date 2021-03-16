using Microsoft.AspNetCore.Mvc;
using Supermercado.Api.Domain.Services;
using Supermercado.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Supermercado.Api.Controllers
{
    [Route("/api/[controller]")]
    public class CategoriasController : Controller
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriasController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet]
        public async Task<IEnumerable<Categoria>> GetAllAsync()
        {
            var categorias = await _categoriaService.ListAsync();
            return categorias;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
