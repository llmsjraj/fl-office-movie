using Microsoft.EntityFrameworkCore;

namespace Api.Business.Repository.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<MovieRating> MovieRatings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Movie 1", Year = 2020 },
                new Movie { Id = 2, Title = "Movie 2", Year = 2019 }
            );

            modelBuilder.Entity<Actor>().HasData(
                new Actor { Id = 1, Name = "Actor 1" },
                new Actor { Id = 2, Name = "Actor 2" }
            );

            modelBuilder.Entity<MovieRating>().HasData(
                new MovieRating { Id = 1, MovieId = 1, Rating = 4 },
                new MovieRating { Id = 2, MovieId = 2, Rating = 5 }
            );
        }
    }
}
