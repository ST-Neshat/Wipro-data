using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieCatalog.Api.Data;
using MovieCatalog.Api.Models;

namespace MovieCatalog.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DirectorsController : ControllerBase
    {
        private readonly AppDbContext _db;

        public DirectorsController(AppDbContext db)
        {
            _db = db;
        }

        // GET: api/directors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Director>>> GetAll()
        {
            var directors = await _db.Directors.AsNoTracking().ToListAsync();
            return Ok(directors);
        }

        // GET: api/directors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Director>> GetById(int id)
        {
            var director = await _db.Directors.FindAsync(id);
            if (director == null)
                return NotFound();

            return Ok(director);
        }

        // POST: api/directors
        [HttpPost]
        public async Task<ActionResult<Director>> Create(Director director)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _db.Directors.Add(director);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = director.Id }, director);
        }

        // PUT: api/directors/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Director director)
        {
            if (id != director.Id)
                return BadRequest();

            _db.Entry(director).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DirectorExists(id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // DELETE: api/directors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var director = await _db.Directors.FindAsync(id);
            if (director == null)
                return NotFound();

            _db.Directors.Remove(director);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool DirectorExists(int id)
        {
            return _db.Directors.Any(d => d.Id == id);
        }
    }
}
