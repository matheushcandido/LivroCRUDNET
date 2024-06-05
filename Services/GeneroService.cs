using LivroCRUDNET.Models;
using LivroCRUDNET.Repositories;

namespace LivroCRUDNET.Services
{
    public class GeneroService
    {
        private readonly GeneroRepository _repository;

        public GeneroService(GeneroRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Genero>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Genero> GetByIdAsync(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(Genero genero)
        {
            await _repository.AddAsync(genero);
        }

        public async Task UpdateAsync(Genero genero)
        {
            await _repository.UpdateAsync(genero);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
