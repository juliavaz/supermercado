using System.Collections.Generic;

namespace Supermercado.Core.Domain.Response
{
    public class ProdutoResponse
    {
        public string Nome { get; set; }
        public short QuantidadePacote { get; set; }
        public IList<CategoriaResponse> Categorias { get; set; }
    }
}
