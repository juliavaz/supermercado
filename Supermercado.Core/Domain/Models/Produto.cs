namespace Supermercado.Core.Domain.Models
{
    public class Produto
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public short QuantidadePacote { get; private set; }
        public EnumUnidadeMedida UnidadeMedida { get; private set; }
        public int CategoriaId { get; private set; }
        public Categoria Categoria { get; private set; }

        public Produto(string nome, short quantidadePacote, EnumUnidadeMedida unidadeMedida, Categoria categoria)
        {
            Nome = nome;
            QuantidadePacote = quantidadePacote;
            UnidadeMedida = unidadeMedida;
            Categoria = categoria;
        }

        protected Produto() { }

    }
}
