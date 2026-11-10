
using Microsoft.AspNetCore.Identity;

namespace FavoriteGames.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string DisplayName { get; set; } = string.Empty;
    }
}
