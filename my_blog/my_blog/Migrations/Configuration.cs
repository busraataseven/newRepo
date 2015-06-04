namespace my_blog.Migrations
{
    using my_blog.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<my_blog.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(my_blog.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
                new Movies
                {
                    Title = "The Godfather",
                    ReleaseDate = DateTime.Parse("1977-1-11"),
                    Genre = "Drama",
                    Rating = "PG",
                    Price = 12M
                },

                 new Movies
                 {
                     Title = "Ghostbusters ",
                     ReleaseDate = DateTime.Parse("1984-3-13"),
                     Genre = "Comedy",
                     Rating = "PG",
                     Price = 8.99M
                 },

                 new Movies
                 {
                     Title = "Ghostbusters 2",
                     ReleaseDate = DateTime.Parse("1986-2-23"),
                     Genre = "Comedy",
                     Rating = "PG",
                     Price = 9.99M
                 },
                 
               new Movies
               {
                   Title = "Rio Bravo",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Western",
                   Rating = "PG",
                   Price = 3.99M
               }
           );
        
        }
    }
}
