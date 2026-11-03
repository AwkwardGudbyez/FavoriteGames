# Favorite Games 🎮

Favorite Games is an ASP.NET Core MVC web application for managing and exploring a personal collection of video games. Built as a student project for .NET Web Development at Waukesha County Technical College (WCTC).

**Live Website:** https://favorite-games-ah6153.azurewebsites.net

## Features

- Browse a collection of video games.
- View game details, including genre, developer, release year, and rating.
- Add, edit, and delete games.
- Write and view game reviews.
- Explore a featured game on the homepage.
- Navigate with helpful empty-state messages and a custom error page.

## Technologies Used

- C# and ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Razor Views
- HTML, CSS, and Bootstrap 5
- Bootswatch Darkly theme
- Microsoft Azure App Service

## Midterm Improvements

1. **Site-wide dark gaming theme:** Replaced the original light theme with Darkly and updated the navigation to create a consistent gaming-inspired appearance.
2. **Redesigned game cards:** Added rating badges, genre, release year, developer information, and clearer navigation buttons.
3. **Improved game details and reviews:** Organized game information into columns, added prominent ratings, improved review cards, and added navigation back to the collection.

## Running Locally

1. Clone the GitHub repository.
2. Open the project folder in VS Code or Visual Studio.
3. Install the appropriate .NET SDK and configure a SQL Server connection.
4. Set the `DefaultConnection` connection string using .NET user secrets or local configuration.
5. Apply database migrations:

   ```bash
   dotnet ef database update
   ```

6. Start the application:

   ```bash
   dotnet watch
   ```

7. Open the localhost URL displayed in the terminal.

## Author

Alik Hansen  
Waukesha County Technical College  
IT Web/Software Development