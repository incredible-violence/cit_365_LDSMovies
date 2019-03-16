using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LDSMovies.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LDSMoviesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LDSMoviesContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The R.M.",
                        ReleaseDate = DateTime.Parse("2003-1-31"),
                        Genre = "Romantic Comedy",
                        Price = 500000,
                        Rating = "PG"
                    },

                    new Movie
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("2004-2-20"),
                        Genre = "Comedy",
                        Price = 400000,
                        Rating = "PG"
                    },

                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-10-10"),
                        Genre = "Documentary",
                        Price = 9999999999,
                        Rating = "PG"
                    },

                    new Movie
                    {
                        Title = "Saints and Soliers",
                        ReleaseDate = DateTime.Parse("2004-8-6"),
                        Genre = "War Film",
                        Price = 780000,
                        Rating = "PG"
                    },

                    new Movie
                    {
                        Title = "The Passion of the Christ",
                        ReleaseDate = DateTime.Parse("2004-2-25"),
                        Genre = "Documentary",
                        Price = 30M,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2001-12-14"),
                        Genre = "Documentary",
                        Price = 7M,
                        Rating = "PG"
                    },

                    new Movie
                    {
                        Title = "Johnny Lingo",
                        ReleaseDate = DateTime.Parse("1969-1-1"),
                        Genre = "Romantic Comedy",
                        Price = 1,
                        Rating = "G"
                    },

                    new Movie
                    {
                        Title = "The Book of Mormon Movie: Volume 1 - The Journey",
                        ReleaseDate = DateTime.Parse("2003-9-12"),
                        Genre = "Book Adaptation",
                        Price = 1,
                        Rating = "PG"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
