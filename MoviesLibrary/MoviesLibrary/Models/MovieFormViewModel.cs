using MovieLibrary.DomainModels;
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

        public IEnumerable<Genre> Genres { get; set; }
    }
}