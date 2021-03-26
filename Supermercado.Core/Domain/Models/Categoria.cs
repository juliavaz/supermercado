using System.Collections.Generic;

namespace Supermercado.Core.Domain.Models
{
    public class Categoria
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public IList<Produto> Produtos { get; private set; } = new List<Produto>();

        public Categoria(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        protected Categoria() { }
    }
}
