using Api.Business.DTOs;
using Api.Business.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Business.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Task<ApiResponse<MovieDto>> AddAsync(MovieDto movie)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<MovieDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<MovieDto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(MovieDto movie)
        {
            throw new NotImplementedException();
        }
    }
}
