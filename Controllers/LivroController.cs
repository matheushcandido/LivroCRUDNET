using LivroCRUDNET.Models;
using LivroCRUDNET.Services;
using Microsoft.AspNetCore.Mvc;

namespace LivroCRUDNET.Controllers
{
    [Route("api/livro")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly LivroService _service;

        public LivroController(LivroService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Livro>>> GetAll()
        {
            var livros = await _service.GetAllAsync();
            return Ok(livros);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Livro>> GetById(Guid id)
        {
            var livro = await _service.GetByIdAsync(id);
            if (livro == null)
            {
                return NotFound();
            }
            return Ok(livro);
        }

        [HttpPost]
        public async Task<ActionResult> Create(Livro livro)
        {
            await _service.AddAsync(livro);
            return CreatedAtAction(nameof(GetById), new { id = livro.Id }, livro);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Guid id, Livro livro)
        {
            if (id != livro.Id)
            {
                return BadRequest();
            }

            await _service.UpdateAsync(livro);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var livro = await _service.GetByIdAsync(id);
            if (livro == null)
            {
                return NotFound();
            }

            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}
