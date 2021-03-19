namespace Supermercado.Core.Domain.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public short QuantidadePacote { get; set; }
        public EnumUnidadeMedida UnidadeMedida { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

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
