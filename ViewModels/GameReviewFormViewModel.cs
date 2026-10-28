
using FavoriteGames.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FavoriteGames.ViewModels;

public class GameReviewFormViewModel
{
    public GameReview Review { get; set; } = new();

    public SelectList? Games { get; set; }
}
