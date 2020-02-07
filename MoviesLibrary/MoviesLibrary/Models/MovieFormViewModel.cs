using MovieLibrary.DomainModels;
using System.Collections.Generic;

namespace MoviesLibrary.Models
{
    public class MovieFormViewModel
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}