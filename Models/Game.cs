namespace FavoriteGames.Web.Models;

public class Game
{
    public int Id {get;set;}
    public string Name {get;set;}="";
    public string Genre {get;set;}="";
    public string Developer {get;set;}="";
    public int YearReleased {get;set;}

}