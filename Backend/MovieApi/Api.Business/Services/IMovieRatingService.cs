using Api.Business.DTOs;

namespace Api.Business.Services
{
    public interface IMovieRatingService
    {
        Task<ApiResponse<MovieRatingDto>> GetByIdAsync(int id);
        Task<ApiResponse<MovieRatingDto>> GetAllAsync();
        Task<ApiResponse<MovieRatingDto>> AddAsync(MovieRatingDto movie);
        Task UpdateAsync(MovieRatingDto movie);
        Task DeleteAsync(int id);
    }
}
