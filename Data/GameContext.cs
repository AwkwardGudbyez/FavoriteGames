
using FavoriteGames.Models;
using Microsoft.EntityFrameworkCore;

namespace FavoriteGames.Web.Data;

public class GameContext : DbContext
{
    public GameContext(DbContextOptions<GameContext> options) : base(options)
    {}

    public DbSet<Game> Games => Set<Game>();
    public DbSet<GameReview> GameReviews => Set<GameReview>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Game>().HasData(
            new Game { Id = 1, Name = "Baldur's Gate 3", Genre = "RPG", Developer = "Larion Studios", YearReleased = 2023 },
            new Game { Id = 2, Name = "World of Warcraft", Genre = "MMORPG", Developer = "Blizzard Entertainment", YearReleased = 2004 },
            new Game { Id = 3, Name = "Ark: Survival Ascended", Genre = "RPG", Developer = "Studio Wildcard", YearReleased = 2023 },
            new Game { Id = 4, Name = "Call of Duty: Black Ops 2", Genre = "First-Person Shooter", Developer = "Treyarch", YearReleased = 2012 },
            new Game { Id = 5, Name = "Tom Clancy's Rainbow Six Siege", Genre = "First-Person Shooter", Developer = "Ubisoft", YearReleased = 2015 }
        );

        modelBuilder.Entity<GameReview>().HasData(
            new GameReview { Id = 1, GameId = 1, ReviewerName = "Alik", Score = 10, Comment = "One of the best RPGs I've ever played!" },
            new GameReview { Id = 2, GameId = 2, ReviewerName = "Alik", Score = 9, Comment = "An incredible MMORPG with years of adventures." },
            new GameReview { Id = 3, GameId = 3, ReviewerName = "Alik", Score = 8, Comment = "Survival, dinosaurs, and exploration. What's not to love?" }
        );
    }
}
