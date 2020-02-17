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

            Genre action = new Genre { Id = "28", Name = "Action" };
            Genre animation = new Genre { Id = "16", Name = "Animation" };
            Genre adventure = new Genre { Id = "12", Name = "Adventure" };
            Genre comedy = new Genre { Id = "35", Name = "Comedy" };
            Genre crime = new Genre { Id = "80", Name = "Crime" };
            Genre documentary = new Genre { Id = "99", Name = "Documentary" };
            Genre drama = new Genre { Id = "18", Name = "Drama" };
            Genre family = new Genre { Id = "10751", Name = "Family" };
            Genre fantasy = new Genre { Id = "14", Name = "Fantasy" };
            Genre history = new Genre { Id = "36", Name = "History" };
            Genre horror = new Genre { Id = "27", Name = "Horror" };
            Genre music = new Genre { Id = "10402", Name = "Music" };
            Genre mystery = new Genre { Id = "9648", Name = "Mystery" };
            Genre romance = new Genre { Id = "10749", Name = "Romance" };
            Genre sf = new Genre { Id = "878", Name = "Science Fiction" };
            Genre tvMovie = new Genre { Id = "10770", Name = "TV Movie" };
            Genre thriller = new Genre { Id = "53", Name = "Thriller" };
            Genre war = new Genre { Id = "10752", Name = "War" };
            Genre western = new Genre { Id = "37", Name = "Western" };
            Genre actionAndAdventure = new Genre { Id = "10759", Name = "Acrion & Adventure" };
            Genre kids = new Genre { Id = "10762", Name = "Kids" };
            Genre news = new Genre { Id = "10763", Name = "News" };
            Genre reality = new Genre { Id = "10764", Name = "Reality" };
            Genre sciFiFantasy = new Genre { Id = "10765", Name = "Sci-Fi & Fantasy" };
            Genre soap = new Genre { Id = "10766", Name = "Soap" };
            Genre talk = new Genre { Id = "10767", Name = "Talk" };
            Genre warAndPolitics = new Genre { Id = "10768", Name = "War & Politics" };


            context.Genres.AddOrUpdate(x => x.Id, action);
            context.Genres.AddOrUpdate(x => x.Id, animation);
            context.Genres.AddOrUpdate(x => x.Id, adventure);
            context.Genres.AddOrUpdate(x => x.Id, comedy);
            context.Genres.AddOrUpdate(x => x.Id, crime);
            context.Genres.AddOrUpdate(x => x.Id, documentary);
            context.Genres.AddOrUpdate(x => x.Id, drama);
            context.Genres.AddOrUpdate(x => x.Id, family);
            context.Genres.AddOrUpdate(x => x.Id, fantasy);
            context.Genres.AddOrUpdate(x => x.Id, history);
            context.Genres.AddOrUpdate(x => x.Id, horror);
            context.Genres.AddOrUpdate(x => x.Id, mystery);
            context.Genres.AddOrUpdate(x => x.Id, music);
            context.Genres.AddOrUpdate(x => x.Id, romance);
            context.Genres.AddOrUpdate(x => x.Id, sf);
            context.Genres.AddOrUpdate(x => x.Id, tvMovie);
            context.Genres.AddOrUpdate(x => x.Id, thriller);
            context.Genres.AddOrUpdate(x => x.Id, western);
            context.Genres.AddOrUpdate(x => x.Id, war);
            context.Genres.AddOrUpdate(x => x.Id, actionAndAdventure);
            context.Genres.AddOrUpdate(x => x.Id, kids);
            context.Genres.AddOrUpdate(x => x.Id, news);
            context.Genres.AddOrUpdate(x => x.Id, reality);
            context.Genres.AddOrUpdate(x => x.Id, sciFiFantasy);
            context.Genres.AddOrUpdate(x => x.Id, soap);
            context.Genres.AddOrUpdate(x => x.Id, talk);
            context.Genres.AddOrUpdate(x => x.Id, warAndPolitics);

        }
    }
}
