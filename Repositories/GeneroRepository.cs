using LivroCRUDNET.Models;
using Microsoft.EntityFrameworkCore;

namespace LivroCRUDNET.Repositories
{
    public class GeneroRepository
    {
        private readonly Context _context;

        public GeneroRepository(Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Genero>> GetAllAsync()
        {
            return await _context.Generos.ToListAsync();
        }

        public async Task<Genero> GetByIdAsync(Guid id)
        {
            return await _context.Generos.FindAsync(id);
        }

        public async Task AddAsync(Genero genero)
        {
            await _context.Generos.AddAsync(genero);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Genero genero)
        {
            _context.Generos.Update(genero);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var genero = await _context.Generos.FindAsync(id);
            if (genero != null)
            {
                _context.Generos.Remove(genero);
                await _context.SaveChangesAsync();
            }
        }
    }
}
