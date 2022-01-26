using crud_filmes_api_aspnetcore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace crud_filmes_api_aspnetcore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly Context _context;

        public MoviesController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetAllMovies()
        {
            return await _context.Movies.ToListAsync();
        }

        [HttpGet("{idMovie}")]
        public async Task<ActionResult<Movie>> GetMovie(int idMovie) 
        {
            Movie movie = await _context.Movies.FindAsync(idMovie);

            if (movie == null)
                return NotFound();

            return movie;
        }

        [HttpPost]
        public async Task<ActionResult<Movie>> SaveMovie(Movie movie) 
        {
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateMovie(Movie movie) 
        {
            _context.Movies.Update(movie);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteMovie(int idMovie)
        {
            Movie movie = await _context.Movies.FindAsync(idMovie);

            if (movie == null)
                return NotFound();
                
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}