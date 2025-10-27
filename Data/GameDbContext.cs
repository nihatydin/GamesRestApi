using Microsoft.EntityFrameworkCore;

namespace GamesRestApi.Data
{
    public class GameDbContext(DbContextOptions<GameDbContext> options) : DbContext(options)
    {
        public DbSet<Game> Games => Set<Game>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Game>().HasData(

                new Game { Id = 1, Title = "The Legend of Zelda: Breath of the Wild", Description = "An open-world action-adventure game set in Hyrule.", Image = "https://example.com/zelda.jpg", Publisher = "Nintendo", Release = "March 3, 2017" },
                new Game { Id = 2, Title = "God of War", Description = "An action-adventure game based on Norse mythology.", Image = "https://example.com/godofwar.jpg", Publisher = "Sony Interactive Entertainment", Release = "April 20, 2018" },
                new Game { Id = 3, Title = "Red Dead Redemption 2", Description = "An epic tale of life in America’s unforgiving heartland.", Image = "https://example.com/rdr2.jpg", Publisher = "Rockstar Games", Release = "October 26, 2018" },
                new Game { Id = 4, Title = "Cyberpunk 2077", Description = "An open-world action RPG set in Night City.", Image = "https://example.com/cyberpunk2077.jpg", Publisher = "CD Projekt", Release = "December 10, 2020" },
                new Game { Id = 5, Title = "Elden Ring", Description = "A dark fantasy action RPG developed with George R. R. Martin.", Image = "https://example.com/eldenring.jpg", Publisher = "Bandai Namco", Release = "February 25, 2022" },
                new Game { Id = 6, Title = "Minecraft", Description = "A sandbox survival game with procedural worlds.", Image = "https://example.com/minecraft.jpg", Publisher = "Mojang Studios", Release = "November 18, 2011" },
                new Game { Id = 7, Title = "The Witcher 3: Wild Hunt", Description = "A story-driven RPG set in a visually stunning fantasy universe.", Image = "https://example.com/witcher3.jpg", Publisher = "CD Projekt", Release = "May 19, 2015" },
                new Game { Id = 8, Title = "Grand Theft Auto V", Description = "An open-world action game set in Los Santos.", Image = "https://example.com/gtav.jpg", Publisher = "Rockstar Games", Release = "September 17, 2013" },
                new Game { Id = 9, Title = "Horizon Forbidden West", Description = "An action RPG exploring post-apocalyptic lands ruled by machines.", Image = "https://example.com/horizonfw.jpg", Publisher = "Sony Interactive Entertainment", Release = "February 18, 2022" },
                new Game { Id = 10, Title = "Assassin’s Creed Valhalla", Description = "A Viking-themed open-world action RPG.", Image = "https://example.com/acvalhalla.jpg", Publisher = "Ubisoft", Release = "November 10, 2020" }

            );
        }
    }
}
