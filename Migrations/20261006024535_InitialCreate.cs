using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FavoriteGames.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Developer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearReleased = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Developer", "Genre", "Name", "YearReleased" },
                values: new object[,]
                {
                    { 1, "Larion Studios", "RPG", "Baldur's Gate 3", 2023 },
                    { 2, "Blizzard Entertainment", "MMORPG", "World of Warcraft", 2004 },
                    { 3, "Studio Wildcard", "RPG", "Ark: Survival Ascended", 2023 },
                    { 4, "Treyarch", "First-Person Shooter", "Call of Duty: Black Ops 2", 2012 },
                    { 5, "Ubisoft", "First-Person Shooter", "Tom Clancy's Rainbow Six Siege", 2015 }
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
