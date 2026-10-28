
using FavoriteGames.Models;
using FavoriteGames.ViewModels;
using FavoriteGames.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FavoriteGames.Controllers;

public class GameReviewsController : Controller
{
    private readonly GameContext _context;

    public GameReviewsController(GameContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Create()
    {
        var form = new GameReviewFormViewModel
        {
            Games = new SelectList(
                await _context.Games.ToListAsync(),
                "Id",
                "Name"
            )
        };

        return View(form);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(
        GameReviewFormViewModel form)
    {
        if (!await _context.Games.AnyAsync(
            g => g.Id == form.Review.GameId))
        {
            ModelState.AddModelError(
                "Review.GameId",
                "Please select a valid game."
            );
        }

        // The Game navigation property is populated by EF,
        // not by the submitted form.
        ModelState.Remove("Review.Game");

        if (ModelState.IsValid)
        {
            _context.GameReviews.Add(form.Review);
            await _context.SaveChangesAsync();

            return RedirectToAction(
                "Details",
                "Games",
                new { id = form.Review.GameId }
            );
        }

        form.Games = new SelectList(
            await _context.Games.ToListAsync(),
            "Id",
            "Name",
            form.Review.GameId
        );

        return View(form);
    }
}
