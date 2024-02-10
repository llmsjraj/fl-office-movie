using Api.Business.Repository.Data;
namespace Api.Business.Repository
{
    public interface IMovieRatingRepository
    {
        Task<MovieRating> GetByIdAsync(int id);
        Task<List<MovieRating>> GetAllAsync();
        Task<MovieRating> AddAsync(MovieRating actor);
        Task<MovieRating> UpdateAsync(MovieRating actor);
        Task DeleteAsync(int id);
    }
}
