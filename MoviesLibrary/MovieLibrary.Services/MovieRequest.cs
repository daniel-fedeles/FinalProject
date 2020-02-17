using TMDbLib.Client;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.Search;

namespace MovieLibrary.Services
{
    public class MovieRequest
    {
        TMDbClient client = new TMDbClient(Resource1.ApiKey);
        SearchMovie sm = new SearchMovie();

        public SearchMovie GetMovies(string query)
        {
            var movies = client.SearchMovieAsync(query).Result;


            foreach (SearchMovie movie in movies.Results)
            {
                if (movie.Title.ToLower() == query.ToLower())
                {
                    sm = movie;
                    break;
                }
            }

            return sm;
        }

        public Movie GetMovieDetails()
        {
            Movie movie = client.GetMovieAsync(sm.Id).Result;
            return movie;

        }


    }
}
