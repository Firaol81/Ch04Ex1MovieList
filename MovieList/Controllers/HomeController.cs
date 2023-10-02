using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MovieList.Models;

namespace MovieList.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext context { get; set; }

        public HomeController(MovieContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            // Retrieve a list of movies, including their associated genres, ordered by name.
            var movies = context.Movies.OrderBy(m => m.Name).ToList();
      
            return View(movies);
        }
    }
}
