using MoviesLibrary.Models;
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

        [Required]
        public string GenreId { get; set; }


    }
}
