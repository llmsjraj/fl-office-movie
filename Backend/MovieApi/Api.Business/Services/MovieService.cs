using Api.Business.DTOs;
using Api.Business.Repository;
using Api.Business.Repository.Data;
using AutoMapper;

namespace Api.Business.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;
        public MovieService(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }

        public async Task<ApiResponse<MovieDto>> AddAsync(MovieDto movie)
        {
            Movie newMovie = _mapper.Map<Movie>(movie);
            Movie addedMovie = await _movieRepository.AddAsync(newMovie);
            MovieDto dto = _mapper.Map<MovieDto>(addedMovie);
            return new ApiResponse<MovieDto>()
            {
                Data = dto,
                Success = true,
                StatusCode = 201
            };
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
