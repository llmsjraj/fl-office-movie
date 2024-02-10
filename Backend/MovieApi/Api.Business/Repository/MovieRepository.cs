using Api.Business.Repository.Data;

namespace Api.Business.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly DataContext _context;

        public MovieRepository(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Movie> AddAsync(Movie movie)
        {
            Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<Movie> movieData = await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
            return movieData.Entity;
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Movie>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Movie> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> UpdateAsync(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
