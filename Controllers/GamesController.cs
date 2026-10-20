using Microsoft.AspNetCore.Mvc;
using FavoriteGames.Models;
using FavoriteGames.Web.Data;
using Microsoft.EntityFrameworkCore;

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

    public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Games.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }
            return View(game);
        }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Genre,Developer,YearReleased")] Game game)
    {
        if (id != game.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(game);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameExists(game.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
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
    private bool GameExists(int id)
{
    return _context.Games.Any(e => e.Id == id);
}
}