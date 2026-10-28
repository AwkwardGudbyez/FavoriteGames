using System.ComponentModel.DataAnnotations;

namespace FavoriteGames.Models;

public class GameReview
{
    public int Id { get; set; }

    public int GameId { get; set; }

    public Game Game { get; set; } = null!;

    [Required]
    [StringLength(60)]
    public string ReviewerName { get; set; } = "";

    [Range(1, 10, ErrorMessage = "Score must be between 1 and 10.")]
    public int Score { get; set; }

    [Required]
    [StringLength(500)]
    public string Comment { get; set; } = "";
}