using Supermercado.Api.Persistence.Contexts;

namespace Supermercado.Api.Persistence.Repositories
{
    public class BaseRepository
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public void SaveChances()
        {
            _context.SaveChanges();
        }
    }
}
