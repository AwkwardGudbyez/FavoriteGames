using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FavoriteGames.Models;
using FavoriteGames.Web.Data;

namespace FavoriteGames.Controllers;

public class HomeController : Controller
{
    private readonly GameContext _context;

    public HomeController(GameContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var featuredGame = _context.Games.FirstOrDefault();
        return View(featuredGame);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}