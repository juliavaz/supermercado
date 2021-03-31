using AutoMapper;
using Supermercado.Core.Domain.Models;
using Supermercado.Core.Domain.Response;

namespace Supermercado.Api.Config
{
    public class AutoMapperConfig
    {
        public static IMapper InitializeMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Categoria, CategoriaResponse>();

            });
            return config.CreateMapper();
        }
    }
}

