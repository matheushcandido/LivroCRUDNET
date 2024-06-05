using LivroCRUDNET.Models;
using LivroCRUDNET.Repositories;

namespace LivroCRUDNET.Services
{
    public class LivroService
    {
        private readonly LivroRepository _repository;

        public LivroService(LivroRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Livro>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Livro> GetByIdAsync(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(Livro livro)
        {
            await _repository.AddAsync(livro);
        }

        public async Task UpdateAsync(Livro livro)
        {
            await _repository.UpdateAsync(livro);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
