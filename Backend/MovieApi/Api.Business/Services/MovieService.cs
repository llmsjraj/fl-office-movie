using Api.Business.DTOs;
using Api.Business.Repository;
using Api.Business.Repository.Data;
using AutoMapper;

namespace Api.Business.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IActorService _actorService;
        private readonly IMapper _mapper;
        public MovieService(IMovieRepository movieRepository, IActorService actorService, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _actorService = actorService;
            _mapper = mapper;
        }

        public async Task<ApiResponse<MovieDto>> AddAsync(CreateMovieDto movie)
        {
            Movie newMovie = _mapper.Map<Movie>(movie);

            // Validate actor IDs
            if (movie.ActorIds != null && movie.ActorIds.Any())
            {
                var actors = await _actorService.GetByIdsAsync(movie.ActorIds);

                if (actors.Data.Count != movie.ActorIds.Count)
                {
                    return new ApiResponse<MovieDto>()
                    {
                        ErrorMessage = $"No actors found with the provided IDs {string.Join(", ", movie.ActorIds)}",
                        Success = false,
                        StatusCode = 400
                    };
                }
                else
                {
                    newMovie.Actors = actors.Data;
                }
            }

            var done = await _movieRepository.AddAsync(newMovie);
            MovieDto newMovieDto = _mapper.Map<MovieDto>(done);
            return new ApiResponse<MovieDto>()
            {
                Success = true,
                Data = newMovieDto,
                StatusCode = 201
            };
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<List<MovieDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<MovieDto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CreateMovieDto movie)
        {
            throw new NotImplementedException();
        }
    }
}
