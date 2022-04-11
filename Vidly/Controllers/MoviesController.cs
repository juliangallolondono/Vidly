using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
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
            return View();
        }
    }
}