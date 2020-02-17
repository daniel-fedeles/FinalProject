using MovieLibrary.DomainModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MoviesLibrary.Models
{
    public class MovieFormViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Genre { get; set; }


        public double Popularity { get; set; }
        public DateTime ReleaseDate { get; set; }

        public string ImgUrl { get; set; }

        public IList<Genre> Genres { get; set; }
        public DateTime Watched { get; set; }
    }
}