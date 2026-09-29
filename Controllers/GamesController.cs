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
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Game game)
    {
        if (!ModelState.IsValid)
        {
            return View(game);
        }
        game.Id = GameData.All.Max(g => g.Id) +1;
        GameData.All.Add(game);

        return RedirectToAction(nameof(Index));
    }
}
