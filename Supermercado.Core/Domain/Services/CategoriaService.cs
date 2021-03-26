using AutoMapper;
using Supermercado.Core.Domain.IRepositories;
using Supermercado.Core.Domain.IServices;
using Supermercado.Core.Domain.Models;
using Supermercado.Core.Domain.Requests;
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

        public IList<CategoriaRequest> List()
        {
            var list = _categoriaRepository.ListAsync().Result;
            var result = _mapper.Map<IList<CategoriaRequest>>(list);
            return result;
        }

        public void Insert(Categoria categoria)
        {
            _categoriaRepository.AddAsync(categoria);
        }

        public void Insert(CategoriaRequest categoriaRequest)
        {
            var categoria = new Categoria(01, categoriaRequest.Nome);
            _categoriaRepository.Insert(categoria);
        }
    }
}
