using MoviesLibrary.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace MovieLibrary.DomainModels
{
    public class Movie
    {

        public string Id { get; set; }


        public ApplicationUser UserApp { get; set; }

        [Required]
        public string UserAppId { get; set; }

        [Required]
        public string MovieName { get; set; }


        public Genre Genre { get; set; }

        public string GenreId { get; set; }

        public DateTime Watched { get; set; }
        public string WatchedWith { get; set; }


    }
}
