namespace FavoriteGames.Web.Models;


public static class GameData
{
    public static List<Game> All {get;} = new()
    {
        new Game {Id = 1, Name = "Baldur's Gate 3", Genre = "RPG", Developer = "Larion Studios", YearReleased = 2023},
        new Game {Id = 2, Name = "World of Warcraft", Genre = "MMORPG", Developer = "Blizzard Entertainment", YearReleased = 2004},
        new Game {Id = 3, Name = "Ark: Survival Ascended", Genre = "RPG", Developer = "Studio Wildcard", YearReleased = 2023},
        new Game {Id = 4, Name = "Call of Duty: Black Ops 2", Genre = "First-Person Shooter", Developer = "Treyarch", YearReleased = 2012},
        new Game {Id = 5, Name = "Tom Clancy's Rainbow Six Siege", Genre = "First-Person Shooter", Developer = "Ubisoft", YearReleased = 2015}
    };
}