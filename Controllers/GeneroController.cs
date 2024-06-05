using LivroCRUDNET.Models;
using LivroCRUDNET.Services;
using Microsoft.AspNetCore.Mvc;

namespace LivroCRUDNET.Controllers
{
    [Route("api/genero")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
        private readonly GeneroService _service;

        public GeneroController(GeneroService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Genero>>> GetAll()
        {
            var generos = await _service.GetAllAsync();
            return Ok(generos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Genero>> GetById(Guid id)
        {
            var genero = await _service.GetByIdAsync(id);
            if (genero == null)
            {
                return NotFound();
            }
            return Ok(genero);
        }

        [HttpPost]
        public async Task<ActionResult> Create(Genero genero)
        {
            await _service.AddAsync(genero);
            return CreatedAtAction(nameof(GetById), new { id = genero.Id }, genero);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Guid id, Genero genero)
        {
            if (id != genero.Id)
            {
                return BadRequest();
            }

            await _service.UpdateAsync(genero);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var genero = await _service.GetByIdAsync(id);
            if (genero == null)
            {
                return NotFound();
            }

            await _service.DeleteAsync(id);
            return NoContent();
        }
    }

}
