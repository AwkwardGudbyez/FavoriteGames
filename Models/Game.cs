using System.ComponentModel.DataAnnotations;

namespace FavoriteGames.Models;

public class Game
{
    public int Id {get;set;}
 
    [Required(ErrorMessage = "Every game has a name.")]
    [StringLength(60, MinimumLength =2)]
    public string Name {get;set;}="";
    public string Genre {get;set;}="";
    public string Developer {get;set;}="";
    public int YearReleased {get;set;}

}