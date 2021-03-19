using Microsoft.EntityFrameworkCore;
using Supermercado.Api.Persistence.Contexts;
using Supermercado.Core.Domain.Models;
using Supermercado.Core.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Supermercado.Api.Persistence.Repositories
{
    public class CategoriaRepository : BaseRepository, ICategoriaRepository
    {
        public CategoriaRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Categoria>> ListAsync()
        {
            return await _context.Categorias.ToListAsync();
        }

        public async Task AddAsync(Categoria categoria)
        {
            await _context.Categorias.AddAsync(categoria);
            _context.SaveChanges();
        }

        public async Task<Categoria> FindByIdAsync(int id)
        {
            return await _context.Categorias.FindAsync(id);
        }

        public void Remove(Categoria categoria)
        {
            _context.Categorias.Remove(categoria);
        }

        public void Update(Categoria categoria)
        {
            _context.Categorias.Update(categoria);
        }
    }
}
