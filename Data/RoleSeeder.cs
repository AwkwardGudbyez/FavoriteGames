using Microsoft.AspNetCore.Identity;
using FavoriteGames.Models;
using Microsoft.Extensions.Configuration;

namespace FavoriteGames.Web.Data;

public static class RoleSeeder
{
    public static async Task SeedAsync(
        IServiceProvider services,
        IConfiguration configuration)
    {
        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
        var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
        const string roleName = "GameAdmin";

        if (!await roleManager.RoleExistsAsync(roleName))
        {
            await roleManager.CreateAsync(new IdentityRole(roleName));
        }
        var adminEmail = configuration["Admin:Email"];

        if (string.IsNullOrWhiteSpace(adminEmail))
        {
            return;
        }
        var adminUser = await userManager.FindByEmailAsync(adminEmail);

        if (adminUser == null)
        {
            return;
        }
        if (!await userManager.IsInRoleAsync(adminUser, roleName))
        {
            await userManager.AddToRoleAsync(adminUser, roleName);
        }
    }
}