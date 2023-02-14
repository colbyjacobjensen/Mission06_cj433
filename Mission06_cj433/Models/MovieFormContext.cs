using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_cj433.Models
{
    public class MovieFormContext : DbContext
    {
        // Constructor
        public MovieFormContext (DbContextOptions<MovieFormContext> options) : base (options)
        {
            // Come back
        }

        public DbSet<FormResponse> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<FormResponse>().HasData(

                // Seeded Database
                new FormResponse
                {
                    MovieID = 1,
                    Category = "Action/Adventure",
                    Title = "The Batman",
                    Year = 2022,
                    Director = "Matt Reaves",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "This was my favorite movie in 2022."
                },

                new FormResponse
                {
                    MovieID = 2,
                    Category = "Western",
                    Title = "Once Upon a Time in the West",
                    Year = 1968,
                    Director = "Sergio Leone",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },

                new FormResponse
                {
                    MovieID = 3,
                    Category = "Action/Adventure",
                    Title = "Gladiator",
                    Year = 2000,
                    Director = "Ridley Scott",
                    Rating = "R",
                    Edited = true,
                    LentTo = "Olivia Jensen",
                    Notes = "This is one of my favorites!"
                }
            );
        }
    }
}