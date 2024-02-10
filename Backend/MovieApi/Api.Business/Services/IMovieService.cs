using Api.Business.DTOs;
using Api.Business.Repository.Data;

namespace Api.Business.Services
{
    public interface IMovieService
    {
        Task<ApiResponse<Movie>> GetByIdAsync(int id);
        Task<ApiResponse<List<Movie>>> GetAllAsync();
        Task<ApiResponse<Movie>> AddAsync(MovieDto movie);
        Task UpdateAsync(MovieDto movie);
        Task DeleteAsync(int id);
    }
}
