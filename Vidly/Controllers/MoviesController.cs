using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;
using System.Linq;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Movies
        public ActionResult Random()
        {
            Movie movie = new Movie() { Name="Shrek!"};
            var customers = new List<Customer>
            {
                new Customer { Name = "Julian Gallo"},
                new Customer { Name = "Tatiana Berrio"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            
            return View(viewModel);
        }

        public ActionResult Index()
        {
            var movies = _context.Movies.Include(item => item.Genre);

            return View(movies);
        }

        public ActionResult Details(int Id)
        {
            Movie movie = _context.Movies.Include(item => item.Genre).ToList().SingleOrDefault(item => item.Id == Id);

            return View(movie);
        }
    }
}