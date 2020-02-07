using Microsoft.AspNet.Identity.EntityFramework;
using MovieLibrary.DomainModels;
using System.Data.Entity;

namespace MoviesLibrary.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("MovieLibrary", throwIfV1Schema: false)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}