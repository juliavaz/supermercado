using System.Collections.Generic;

namespace Supermercado.Api.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IList<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
