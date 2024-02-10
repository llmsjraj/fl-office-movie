using Api.Business.DTOs;
using Api.Business.Repository;
using AutoMapper;

namespace Api.Business.Services
{
    public class MovieRatingService : IMovieRatingService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;
        public MovieRatingService(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }

        public Task<ApiResponse<MovieRatingDto>> AddAsync(MovieRatingDto movie)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<MovieRatingDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<MovieRatingDto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(MovieRatingDto movie)
        {
            throw new NotImplementedException();
        }
    }
}
