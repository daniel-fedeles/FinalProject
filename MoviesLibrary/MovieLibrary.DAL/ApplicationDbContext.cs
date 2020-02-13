using log4net;
using Microsoft.AspNet.Identity.EntityFramework;
using MovieLibrary.DomainModels;
using System.Data.Entity;
using System.Reflection;

namespace MoviesLibrary.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly ILog _logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public ApplicationDbContext()
            : base("MovieLibrary", throwIfV1Schema: false)
        {
            Database.Log = log => _logger.Debug(log);
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}