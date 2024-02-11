using Api.Business.DTOs;
using Api.Business.Repository.Data;

namespace Api.Business.Services
{
    public interface IMovieService
    {
        Task<ApiResponse<MovieDto>> GetByIdAsync(int id);
        Task<ApiResponse<List<MovieDto>>> GetAllAsync();
        Task<ApiResponse<MovieDto>> AddAsync(CreateMovieDto movie);
        Task UpdateAsync(CreateMovieDto movie);
        Task DeleteAsync(int id);
    }
}
