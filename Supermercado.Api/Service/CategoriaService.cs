using Supermercado.Api.Domain.Repositories;
using Supermercado.Api.Domain.Services;
using Supermercado.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Supermercado.Api.Service
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public async Task<IEnumerable<Categoria>> ListAsync()
        {
            return await _categoriaRepository.ListAsync();
        }
    }
}
