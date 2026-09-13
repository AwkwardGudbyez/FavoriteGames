using FavoriteGames.Models;
using Microsoft.AspNetCore.Mvc;

namespace FavoriteGames.Controllers;

public class GamesController : Controller
{
    public IActionResult Index()
    {
        return View(GameData.All);
    }

    public IActionResult Details(int id)
    {
        var game = GameData.All.FirstOrDefault(g => g.Id == id);
        if (game == null)
        {
            return NotFound();
        }
        return View(game);
    }
}