using MoviesLibrary.Models;

namespace MovieLibrary.DAL.Repositories
{
    public class MoviesRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public MoviesRepository(ApplicationDbContext context)
        {
            _dbContext = context;
        }



    }
}
