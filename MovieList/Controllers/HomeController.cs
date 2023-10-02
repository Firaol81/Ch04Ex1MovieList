using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieList.Models;

namespace MovieList.Controllers
{
    public class HomeController : Controller
    {
        private readonly MovieContext _context;

        public HomeController(MovieContext ctx)
        {
            _context = ctx;
        }

        public IActionResult Index()
        {
            // Retrieve a list of movies, including their associated genres, ordered by name.
            var movies = _context.Movies
                .Include(m => m.Genre) // Include the Genre navigation property.
                .OrderBy(m => m.Name)  // Order the movies by name.
                .ToList();             // Convert the result to a list.

            // Pass the list of movies to the "Index" view.
            return View(movies);
        }
    }
}
