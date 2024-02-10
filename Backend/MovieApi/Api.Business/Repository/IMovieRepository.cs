using Api.Business.Repository.Data;

namespace Api.Business.Repository
{
    public interface IMovieRepository
    {
        Task<Movie> GetByIdAsync(int id);
        Task<List<Movie>> GetAllAsync();
        Task<Movie> AddAsync(Movie movie);
        Task<Movie> UpdateAsync(Movie movie);
        Task DeleteAsync(int id);
    }
}
