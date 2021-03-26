using Microsoft.EntityFrameworkCore;
using Supermercado.Api.Persistence.Contexts;
using Supermercado.Core.Domain.IRepositories;
using Supermercado.Core.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Supermercado.Api.Persistence.Repositories
{
    public class ProdutoRepository : BaseRepository, IProdutoRepository
    {
        public ProdutoRepository(AppDbContext appDbContext) : base(appDbContext) { }

        public void Insert(Produto produto)
        {
            _context.Add(produto);
        }

        public async Task<IEnumerable<Produto>> ListAsync()
        {
            return await _context.Produtos
                .Include(x => x.Categoria)
                .ToListAsync();
        }

        public async Task AddAsync(Produto produto)
        {
            await _context.Produtos.AddAsync(produto);
            _context.SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
