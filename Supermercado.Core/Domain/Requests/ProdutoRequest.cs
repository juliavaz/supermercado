using System.Collections.Generic;

namespace Supermercado.Core.Domain.Requests
{
    public class ProdutoRequest
    {
        public string Nome { get; set; }
        public short QuantidadePacote { get; set; }
        public IList<CategoriaRequest> Categorias { get; set; }
    }
}
