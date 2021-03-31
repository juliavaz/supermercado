using AutoMapper;
using Supermercado.Core.Domain.Interfaces;
using Supermercado.Core.Domain.Models;
using Supermercado.Core.Domain.Response;
using System.Collections.Generic;

namespace Supermercado.Core.Domain.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IMapper _mapper;

        public CategoriaService(ICategoriaRepository categoriaRepository, IMapper mapper)
        {
            _categoriaRepository = categoriaRepository;
            _mapper = mapper;
        }

        public IList<CategoriaResponse> List()
        {
            var list = _categoriaRepository.ListAsync().Result;
            var result = _mapper.Map<IList<CategoriaResponse>>(list);
            return result;
        }

        public void Insert(Categoria categoria)
        {
            _categoriaRepository.AddAsync(categoria);
        }

        public void Insert(CategoriaResponse categoriaResponse)
        {
            var categoria = new Categoria(01, categoriaResponse.Nome);

            _categoriaRepository.AddAsync(categoria);
            _categoriaRepository.Insert(categoria);
        }
    }
}
