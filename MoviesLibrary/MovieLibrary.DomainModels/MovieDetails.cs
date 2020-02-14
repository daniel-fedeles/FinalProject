using System;

namespace MovieLibrary.DomainModels
{
    public class MovieDetails
    {
        public int Id { get; set; }
        public string Popularity { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }

    }
}