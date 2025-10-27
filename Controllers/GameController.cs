using GamesRestApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GamesRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {

        private readonly GameDbContext _context;
        public GameController(GameDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<Game>>> GetAllGames()
        {
            return Ok(await _context.Games.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Game>> GetGameById(int id)
        {
            var game = await _context.Games.FindAsync(id);
            if (game == null)
                return NotFound();

            return Ok(game);
        }
        [HttpPost]
        public async Task<ActionResult<Game>> CreateGame(Game newGame)
        {
            if (newGame == null)           
                return BadRequest();

            _context.Games.Add(newGame);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetGameById), new { id = newGame.Id }, newGame);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGame(int id, Game updatedGame)
        {
            var game = await _context.Games.FindAsync(id);
            if (game == null)
                return NotFound();

            game.Title = updatedGame.Title;
            game.Description = updatedGame.Description;
            game.Image = updatedGame.Image;
            game.Publisher = updatedGame.Publisher;
            game.Release = updatedGame.Release;

            await _context.SaveChangesAsync();

            return Ok(game);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGame(int id)
        {
            var game = await _context.Games.FindAsync(id);
            if (game == null)
                return NotFound();
            
            _context.Games.Remove(game);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    };
}
