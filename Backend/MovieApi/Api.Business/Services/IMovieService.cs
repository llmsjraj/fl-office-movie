using Api.Business.DTOs;
using Api.Business.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
