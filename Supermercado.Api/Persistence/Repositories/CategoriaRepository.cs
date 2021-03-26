using Microsoft.EntityFrameworkCore;
using Supermercado.Api.Persistence.Contexts;
using Supermercado.Core.Domain.IRepositories;
using Supermercado.Core.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Supermercado.Api.Persistence.Repositories
{
    public class CategoriaRepository : BaseRepository, ICategoriaRepository
    {
        public CategoriaRepository(AppDbContext appDbContext) : base(appDbContext) { }

        public void Insert(Categoria categoria)
        {
            _context.Add(categoria);
        }

        public async Task<IEnumerable<Categoria>> ListAsync()
        {
            return await _context.Categorias.ToListAsync();
        }

        public async Task<Categoria> FindByIdAsync(int id)
        {
            return await _context.Categorias.FindAsync(id);
        }

        public void Remove(Categoria categoria)
        {
            _context.Categorias.Remove(categoria);
        }

        public async Task AddAsync(Categoria categoria)
        {
            await _context.Categorias.AddAsync(categoria);
            _context.SaveChanges();
        }

        public void Update(Categoria categoria)
        {
            _context.Categorias.Update(categoria);
        }
    }
}
