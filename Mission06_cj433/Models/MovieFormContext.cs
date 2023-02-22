using Microsoft.EntityFrameworkCore;

namespace Mission06_cj433.Models
{
    public class MovieFormContext : DbContext
    {
        // Constructor
        public MovieFormContext (DbContextOptions<MovieFormContext> options) : base (options)
        {
            // Come back
        }

        public DbSet<FormResponse> Responses { get; set; } // Form Responses Model
        public DbSet<Category> Categories { get; set; } // Categories Model

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                // Categories
                new Category { CategoryID = 1, CategoryName = "Action/Adventure" },
                new Category { CategoryID = 2, CategoryName = "Western" },
                new Category { CategoryID = 3, CategoryName = "Romance/Drama" }, 
                new Category { CategoryID = 4, CategoryName = "Comedy" }, 
                new Category { CategoryID = 5, CategoryName = "Sci-Fi" }, 
                new Category { CategoryID = 6, CategoryName = "Thriller" }, 
                new Category { CategoryID = 7, CategoryName = "Horror" }, 
                new Category { CategoryID = 8, CategoryName = "Animation" }
            );

            mb.Entity<FormResponse>().HasData(
                // Seeded Database
                new FormResponse
                {
                    MovieID = 1,
                    CategoryID = 1,
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
                    CategoryID = 2,
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
                    CategoryID = 1,
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