using Api.Business.Repository.Data;

namespace Api.Business.Repository
{
    public interface IMovieRepository
    {
        Task<Movie> GetByIdAsync(int id);
        Task<List<Movie>> GetAllAsync();
        Task AddAsync(Movie movie);
        Task UpdateAsync(Movie movie);
        Task DeleteAsync(int id);
    }
}
