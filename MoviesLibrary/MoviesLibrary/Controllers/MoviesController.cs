using Microsoft.AspNet.Identity;
using MovieLibrary.DomainModels;
using MoviesLibrary.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace MoviesLibrary.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public MoviesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new MovieFormViewModel()
            {
                Genres = _dbContext.Genres.ToList()
            };
            return View(viewModel);
        }
        [Authorize]
        [HttpPost]
        public ActionResult Create(MovieFormViewModel viewModel)
        {
            var movie = new Movie()
            {
                Id = Guid.NewGuid().ToString(),
                MovieName = viewModel.Name,
                UserAppId = User.Identity.GetUserId(),
                GenreId = viewModel.Genre
            };
            // _dbContext.Database.Log = 
            _dbContext.Movies.Add(movie);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}