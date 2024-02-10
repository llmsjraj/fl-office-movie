using Api.Business.DTOs;
using Api.Business.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : BaseHandlingController
    {
        private readonly IMovieService _movieService;
        private readonly ILogger<MoviesController> _logger;
        private readonly IMapper _mapper;

        public MoviesController(IMovieService movieService, IMapper mapper, ILogger<MoviesController> logger)
        {
            _movieService = movieService;
            _mapper = mapper;
            _logger = logger;
        }


        [HttpPost]
        public async Task<ActionResult<ApiResponse<MovieDto>>> AddMovie([FromBody] MovieDto movieDto)
        {
            try
            {
                ApiResponse<MovieDto> response = new ApiResponse<MovieDto>();

                // Handle model validation errors
                ActionResult<ApiResponse<MovieDto>> validationErrorResult = HandleValidationErrors<MovieDto>();
                if (validationErrorResult != null)
                {
                    return validationErrorResult;
                }

                var data = await _movieService.AddAsync(movieDto);
                if (data.Success)
                {
                    MovieDto newMovie = _mapper.Map<MovieDto>(data.Data);
                    newMovie.ActorIds = movieDto.ActorIds;
                    return new ApiResponse<MovieDto>()
                    {
                        Data = newMovie,
                        StatusCode = data.StatusCode,
                        Success = true
                    };
                }

                return new ApiResponse<MovieDto>()
                {
                    ErrorMessage = data.ErrorMessage,
                    Success = false,
                    StatusCode = data.StatusCode,
                    Errors = data.Errors
                };
            }
            catch (Exception ex)
            {
                return GetResultByException(ex);
            }
        }
    }
}
