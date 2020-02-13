﻿using log4net;
using Microsoft.AspNet.Identity;
using MovieLibrary.DomainModels;
using MoviesLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;

namespace MoviesLibrary.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        protected ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        // private readonly ILog _log;

        public MoviesController()
        {
            _dbContext = new ApplicationDbContext();
            // log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

            // _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            _log.Info("StartLog");
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new MovieFormViewModel()
            {
                Genres = _dbContext.Genres.ToList(),

            };
            _log.Info(viewModel);
            return View(viewModel);
        }
        [Authorize]
        [HttpPost]
        public ActionResult Create(MovieFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Genres = _dbContext.Genres.ToList();
                _log.Info(viewModel);
                return View("Create", viewModel);
            }
            var movie = new Movie()
            {
                Id = Guid.NewGuid().ToString(),
                MovieName = viewModel.Name,
                UserAppId = User.Identity.GetUserId(),
                GenreId = viewModel.Genre
            };
            _log.Info(viewModel);
            _log.Info(movie);
            _dbContext.Movies.Add(movie);
            _dbContext.SaveChanges();
            return RedirectToAction("ViewMovies", "Movies");
        }

        public ActionResult ViewMovies()
        {
            List<MovieFormViewModel> viewModels = new List<MovieFormViewModel>();

            var userId = User.Identity.GetUserId();
            var movies = _dbContext.Movies.Where(movie => movie.UserAppId == userId).ToList();
            foreach (var movie in movies)
            {
                var viewModel = new MovieFormViewModel();
                viewModel.Name = movie.MovieName;
                viewModels.Add(viewModel);
            }
            _log.Info(viewModels);
            _log.Info(movies);
            return View(viewModels);
        }
    }
}