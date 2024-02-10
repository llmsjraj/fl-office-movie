using Api.Business.DTOs;
using Api.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : BaseHandlingController
    {
        private readonly IMovieService _movieService;
        private readonly ILogger<MoviesController> _logger;

        public MoviesController(IMovieService movieService, ILogger<MoviesController> logger)
        {
            _movieService = movieService;
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

                return await _movieService.AddAsync(movieDto);
            }
            catch (Exception ex)
            {
                return GetResultByException(ex);
            }
        }
    }
}
