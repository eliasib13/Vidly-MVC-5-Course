using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Movies
        public ActionResult Index()
        {
            var movies = new MovieViewModel
            {
                Movies = _context.Movies.Include(c => c.Genre).ToList(),
                ViewHeader = "Movies"
            };

            return View(movies);
        }

        // GET: Details
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(m => m.Id == id);

            return View(movie);
        }
    }
}