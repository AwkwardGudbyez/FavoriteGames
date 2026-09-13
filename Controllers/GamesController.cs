using FavoriteGames.Models;
using FavoriteGames.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace FavoriteGames.Controllers;

public class GamesController : Controller
{
    public IActionResult Index()
    {
        return View(GameData.All);
    }
}