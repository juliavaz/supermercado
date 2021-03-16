using Microsoft.EntityFrameworkCore;
using Supermercado.Api.Models;

namespace Supermercado.Api.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        // responsável por passar as configs do banco de dados
        // para a classe base através da injeção de dependêcia
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Categoria>(
                b => {
                    b.ToTable("Categorias");
                    b.HasKey(p => p.Id); // hasKey -> primary key
                    b.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();  // property -> colunas e restrições
                    b.Property(p => p.Nome).IsRequired().HasMaxLength(50);
                    b.HasMany(p => p.Produtos).WithOne(p => p.Categoria).HasForeignKey(p => p.CategoriaId);
                    b.HasData(
                        // hasData -> configuração para alimentar os dados
                        // Id definido manualmente pois é um provedor in-memory                        
                        new Categoria { Id = 100, Nome = "Frutas e Vegetais" },
                        new Categoria { Id = 101, Nome = "Laticínios" }
                    );
                });

            builder.Entity<Produto>(
                b => {
                    b.ToTable("Produtos");
                    b.HasKey(p => p.Id);
                    b.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
                    b.Property(p => p.Nome).IsRequired().HasMaxLength(50);
                    b.Property(p => p.QuantidadePacote).IsRequired();
                    b.Property(p => p.UnidadeMedida).IsRequired();
                });
        }
    }
}
