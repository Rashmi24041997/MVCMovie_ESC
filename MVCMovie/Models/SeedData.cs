using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using MVCMovie.Data;

namespace MVCMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var cntxt = new MVCMovieContext(serviceProvider.GetRequiredService<DbContextOptions<MVCMovieContext>>()))
            {
                //Look out for any movies
                if (cntxt.Movie.Any())
                    return;    //Db has been seeded

                cntxt.Movie.AddRange(
                    new Movie
                    {
                        Title = "ZNMD",
                        ReleaseDate = DateTime.Parse("2012-02-02"),
                        Genre = "Romantic Comedy",
                        Price = 200
                    },
                    new Movie
                    {
                        Title = "RHTDM",
                        ReleaseDate = DateTime.Parse("2002-12-22"),
                        Genre = "Romantic Comedy",
                        Price = 300
                    },
                    new Movie
                    {
                        Title = "Bhagat Singh",
                        ReleaseDate = DateTime.Parse("2003-11-23"),
                        Genre = "Patriotic",
                        Price = 250
                    },
                    new Movie
                    {
                        Title = "AntMan",
                        ReleaseDate = DateTime.Parse("2015-11-23"),
                        Genre = "Thriller",
                        Price = 350
                    });
                cntxt.SaveChanges();
            }
        }
    }
}
