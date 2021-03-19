using Supermercado.Core.Domain.Models;
using Supermercado.Core.Domain.Repositories;
using Supermercado.Core.Domain.Services;
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

        public void Insert(Categoria categoria)
        {
            _categoriaRepository.AddAsync(categoria);
        }

    }
}
