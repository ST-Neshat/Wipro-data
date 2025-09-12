using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieCatalog.Api.Data;
using MovieCatalog.Api.Models;

namespace MovieCatalog.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly AppDbContext _db;

        public MoviesController(AppDbContext db)
        {
            _db = db;
        }

        // GET: api/movies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetAll()
        {
            var movies = await _db.Movies
                                  .Include(m => m.Director) // Director info include karo
                                  .AsNoTracking()
                                  .ToListAsync();
            return Ok(movies);
        }

        // GET: api/movies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetById(int id)
        {
            var movie = await _db.Movies
                                 .Include(m => m.Director)
                                 .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
                return NotFound();

            return Ok(movie);
        }

        // GET: api/directors/5/movies
        [HttpGet("/api/directors/{directorId}/movies")]
        public async Task<ActionResult<IEnumerable<Movie>>> GetByDirector(int directorId)
        {
            var director = await _db.Directors.FindAsync(directorId);
            if (director == null)
                return NotFound();

            var movies = await _db.Movies
                                  .Where(m => m.DirectorId == directorId)
                                  .AsNoTracking()
                                  .ToListAsync();
            return Ok(movies);
        }

        // POST: api/movies
        [HttpPost]
        public async Task<ActionResult<Movie>> Create(Movie movie)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var directorExists = await _db.Directors.AnyAsync(d => d.Id == movie.DirectorId);
            if (!directorExists)
                return BadRequest("Invalid DirectorId");

            _db.Movies.Add(movie);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = movie.Id }, movie);
        }

        // PUT: api/movies/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Movie movie)
        {
            if (id != movie.Id)
                return BadRequest();

            var directorExists = await _db.Directors.AnyAsync(d => d.Id == movie.DirectorId);
            if (!directorExists)
                return BadRequest("Invalid DirectorId");

            _db.Entry(movie).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // DELETE: api/movies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var movie = await _db.Movies.FindAsync(id);
            if (movie == null)
                return NotFound();

            _db.Movies.Remove(movie);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool MovieExists(int id)
        {
            return _db.Movies.Any(m => m.Id == id);
        }
    }
}
