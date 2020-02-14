using TMDbLib.Client;
using TMDbLib.Objects.Search;

namespace MovieLibrary.Services
{
    public class MovieRequest
    {
        TMDbClient client = new TMDbClient(Resource1.ApiKey);

        public SearchMovie GetMovies(string query)
        {
            var movies = client.SearchMovieAsync(query).Result;

            var serchMovie = new SearchMovie();

            foreach (SearchMovie movie in movies.Results)
            {
                if (movie.Title.ToLower() == query.ToLower())
                {
                    serchMovie = movie;
                    break;
                }
            }

            return serchMovie;
        }

        public void zzz()
        {
            // var movie = client.GetMovieAsync().Result;

        }
    }
}
