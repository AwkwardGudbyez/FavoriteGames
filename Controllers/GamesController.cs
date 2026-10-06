using Microsoft.AspNetCore.Mvc;
using FavoriteGames.Models;
using FavoriteGames.Web.Data;

namespace FavoriteGames.Controllers;

public class GamesController : Controller
{
    private readonly GameContext _context;

    public GamesController(GameContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Games.ToList());
    }

    public IActionResult Details(int id)
    {
        var game = _context.Games.FirstOrDefault(g => g.Id == id);

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

        _context.Games.Add(game);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }
}