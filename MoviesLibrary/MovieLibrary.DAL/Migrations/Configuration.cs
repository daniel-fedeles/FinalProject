using System;
using MovieLibrary.DomainModels;

namespace MovieLibrary.DAL.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<MoviesLibrary.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MoviesLibrary.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            Genre action = new Genre { Id = Guid.NewGuid().ToString(), Name = "Acction" };
            Genre animation = new Genre { Id = Guid.NewGuid().ToString(), Name = "Animation" };
            Genre adventure = new Genre { Id = Guid.NewGuid().ToString(), Name = "Adventure" };
            Genre comedy = new Genre { Id = Guid.NewGuid().ToString(), Name = "Comedy" };
            Genre crime = new Genre { Id = Guid.NewGuid().ToString(), Name = "Crime" };
            Genre drama = new Genre { Id = Guid.NewGuid().ToString(), Name = "Drama" };
            Genre fantasy = new Genre { Id = Guid.NewGuid().ToString(), Name = "Fantasy" };
            Genre historical = new Genre { Id = Guid.NewGuid().ToString(), Name = "Historical" };
            Genre horror = new Genre { Id = Guid.NewGuid().ToString(), Name = "Horror" };
            Genre mystery = new Genre { Id = Guid.NewGuid().ToString(), Name = "Mystery" };
            Genre romance = new Genre { Id = Guid.NewGuid().ToString(), Name = "Romance" };
            Genre sf = new Genre { Id = Guid.NewGuid().ToString(), Name = "SF" };
            Genre thriller = new Genre { Id = Guid.NewGuid().ToString(), Name = "Thriller" };
            Genre western = new Genre { Id = Guid.NewGuid().ToString(), Name = "Western" };

            context.Genres.AddOrUpdate(x => x.Id, action);
            context.Genres.AddOrUpdate(x => x.Id, animation);
            context.Genres.AddOrUpdate(x => x.Id, adventure);
            context.Genres.AddOrUpdate(x => x.Id, comedy);
            context.Genres.AddOrUpdate(x => x.Id, crime);
            context.Genres.AddOrUpdate(x => x.Id, drama);
            context.Genres.AddOrUpdate(x => x.Id, fantasy);
            context.Genres.AddOrUpdate(x => x.Id, historical);
            context.Genres.AddOrUpdate(x => x.Id, horror);
            context.Genres.AddOrUpdate(x => x.Id, mystery);
            context.Genres.AddOrUpdate(x => x.Id, romance);
            context.Genres.AddOrUpdate(x => x.Id, sf);
            context.Genres.AddOrUpdate(x => x.Id, thriller);
            context.Genres.AddOrUpdate(x => x.Id, western);

        }
    }
}
