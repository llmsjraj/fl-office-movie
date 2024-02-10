using Api.Business.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
