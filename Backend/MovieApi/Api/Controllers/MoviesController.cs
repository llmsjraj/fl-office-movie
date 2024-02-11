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


        [ProducesResponseType(typeof(ApiResponse<MovieDto>), 201)]
        [ProducesResponseType(typeof(ApiResponse<MovieDto>), 400)]
        [ProducesResponseType(typeof(string), 401)]
        [HttpPost]
        public async Task<ActionResult<ApiResponse<MovieDto>>> AddMovie([FromBody] CreateMovieDto movieDto)
        {
            try
            {
                ApiResponse<CreateMovieDto> response = new ApiResponse<CreateMovieDto>();

                // Handle model validation errors
                ActionResult<ApiResponse<MovieDto>> validationErrorResult = HandleValidationErrors<MovieDto>();
                if (validationErrorResult != null)
                {
                    return validationErrorResult;
                }

                var data = await _movieService.AddAsync(movieDto);
                if (data.Success)
                {
                    return CreatedAtAction(nameof(AddMovie), new { id = data.Data.Id }, data);
                }
                else
                {
                    return BadRequest(data);
                }
            }
            catch (Exception ex)
            {
                return GetResultByException(ex);
            }
        }
    }
}
