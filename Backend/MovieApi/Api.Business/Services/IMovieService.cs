using Api.Business.DTOs;

namespace Api.Business.Services
{
    public interface IMovieService
    {
        Task<ApiResponse<MovieDto>> GetByIdAsync(int id);
        Task<ApiResponse<MovieDto>> GetAllAsync();
        Task<ApiResponse<MovieDto>> AddAsync(MovieDto movie);
        Task UpdateAsync(MovieDto movie);
        Task DeleteAsync(int id);
    }
}
