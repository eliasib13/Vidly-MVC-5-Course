using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = new MovieViewModel
            {
                Movies = new List<Movie>
                {
                    new Movie {Name = "The Godfather"},
                    new Movie {Name = "Pulp fiction"}
                },
                ViewHeader = "Movies"
            };
            return View(movies);
        }
    }
}