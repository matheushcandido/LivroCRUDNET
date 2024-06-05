using LivroCRUDNET.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LivroCRUDNET.Repositories
{
    public class LivroRepository
    {
        private readonly Context _context;

        public LivroRepository(Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Livro>> GetAllAsync()
        {
            return await _context.Livros.ToListAsync();
        }

        public async Task<Livro> GetByIdAsync(Guid id)
        {
            return await _context.Livros.FindAsync(id);
        }

        public async Task AddAsync(Livro livro)
        {
            await _context.Livros.AddAsync(livro);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Livro livro)
        {
            _context.Livros.Update(livro);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var livro = await _context.Livros.FindAsync(id);
            if (livro != null)
            {
                _context.Livros.Remove(livro);
                await _context.SaveChangesAsync();
            }
        }
    }
}
