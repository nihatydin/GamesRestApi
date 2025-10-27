using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GamesRestApi.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Release = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "Image", "Publisher", "Release", "Title" },
                values: new object[,]
                {
                    { 1, "An open-world action-adventure game set in Hyrule.", "https://example.com/zelda.jpg", "Nintendo", "March 3, 2017", "The Legend of Zelda: Breath of the Wild" },
                    { 2, "An action-adventure game based on Norse mythology.", "https://example.com/godofwar.jpg", "Sony Interactive Entertainment", "April 20, 2018", "God of War" },
                    { 3, "An epic tale of life in America’s unforgiving heartland.", "https://example.com/rdr2.jpg", "Rockstar Games", "October 26, 2018", "Red Dead Redemption 2" },
                    { 4, "An open-world action RPG set in Night City.", "https://example.com/cyberpunk2077.jpg", "CD Projekt", "December 10, 2020", "Cyberpunk 2077" },
                    { 5, "A dark fantasy action RPG developed with George R. R. Martin.", "https://example.com/eldenring.jpg", "Bandai Namco", "February 25, 2022", "Elden Ring" },
                    { 6, "A sandbox survival game with procedural worlds.", "https://example.com/minecraft.jpg", "Mojang Studios", "November 18, 2011", "Minecraft" },
                    { 7, "A story-driven RPG set in a visually stunning fantasy universe.", "https://example.com/witcher3.jpg", "CD Projekt", "May 19, 2015", "The Witcher 3: Wild Hunt" },
                    { 8, "An open-world action game set in Los Santos.", "https://example.com/gtav.jpg", "Rockstar Games", "September 17, 2013", "Grand Theft Auto V" },
                    { 9, "An action RPG exploring post-apocalyptic lands ruled by machines.", "https://example.com/horizonfw.jpg", "Sony Interactive Entertainment", "February 18, 2022", "Horizon Forbidden West" },
                    { 10, "A Viking-themed open-world action RPG.", "https://example.com/acvalhalla.jpg", "Ubisoft", "November 10, 2020", "Assassin’s Creed Valhalla" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
