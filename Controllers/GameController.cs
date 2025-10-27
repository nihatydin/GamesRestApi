using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace GamesRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        static private List<Game> games = new List<Game>
        {
            new Game
            {
                Id = 1,
                Title = "The Legend of Zelda: Breath of the Wild",
                Description = "An open-world adventure game set in the kingdom of Hyrule.",
                Image = "https://example.com/zelda.jpg",
                Publisher = "Nintendo",
                Release = "March 3, 2017"
            },
            new Game
            {
                Id = 2,
                Title = "God of War",
                Description = "An action-adventure game based on Norse mythology.",
                Image = "https://example.com/godofwar.jpg",
                Publisher = "Sony Interactive Entertainment",
                Release = "April 20, 2018"
            },
            new Game
            {
                Id = 3,
                Title = "The Legend of Zelda 2",
                Description = "An open-world adventure game set in the kingdom of Hyrule.",
                Image = "https://example.com/zelda.jpg",
                Publisher = "Nintendo",
                Release = "March 3, 2017"
            },
            new Game
            {
                Id = 4,
                Title = "God of War 2",
                Description = "An action-adventure game based on Norse mythology.",
                Image = "https://example.com/godofwar.jpg",
                Publisher = "Sony Interactive Entertainment",
                Release = "April 20, 2018"
            }
        };


        [HttpGet]
        public ActionResult<List<Game>> GetAllGames()
        {
            return Ok(games);
        }
        [HttpGet("{id}")]
        public ActionResult<Game> GetGameById(int id)
        {
            var game = games.FirstOrDefault(g => g.Id == id);
            if (game == null)
            {
                return NotFound();
            }
            return Ok(game);
        }
        [HttpPost]
        public ActionResult<Game> CreateGame(Game newGame)
        {
            newGame.Id = games.Max(g => g.Id) + 1;
            games.Add(newGame);
            return CreatedAtAction(nameof(GetGameById), new { id = newGame.Id }, newGame);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateGame(int id, Game updatedGame)
        {
            var game = games.FirstOrDefault(g => g.Id == id);
            if (game == null)
            {
                return NotFound();
            }
            game.Title = updatedGame.Title;
            game.Description = updatedGame.Description;
            game.Image = updatedGame.Image;
            game.Publisher = updatedGame.Publisher;
            game.Release = updatedGame.Release;
            return Ok(game);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteGame(int id)
        {
            var game = games.FirstOrDefault(g => g.Id == id);
            if (game == null)
            {
                return NotFound();
            }
            games.Remove(game);
            return NoContent();
        }
    };
}
