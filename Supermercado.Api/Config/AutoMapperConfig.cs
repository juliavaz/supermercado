using AutoMapper;
using Supermercado.Core.Domain.Models;
using Supermercado.Core.Domain.Requests;

namespace Supermercado.Api.Config
{
    public class AutoMapperConfig
    {
        public static IMapper InitializeMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Categoria, CategoriaRequest>();

            });
            return config.CreateMapper();
        }
    }
}

