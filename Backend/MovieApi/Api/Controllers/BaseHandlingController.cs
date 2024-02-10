using Api.Business.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Api.Controllers
{
    public class BaseHandlingController: ControllerBase
    {
        /// <summary>
        /// Gets result object by committed exception.
        /// </summary>
        /// <param name="ex">Reference to catched exception.</param>
        /// <returns>Return a result object including the status code.</returns>
        protected ObjectResult GetResultByException(Exception ex)
        {
            var exType = ex.GetType();

            int statusCode;
            if (typeof(UnauthorizedAccessException) == exType)
            {
                statusCode = StatusCodes.Status401Unauthorized;
            }
            else
            {
                statusCode = StatusCodes.Status400BadRequest;
            }

            var response = new ApiResponse<object>();

            response.StatusCode = statusCode;
            response.ErrorMessage = ex.Message;

            return StatusCode(statusCode, response);
        }

        protected ActionResult<ApiResponse<T>> HandleValidationErrors<T>()
        {
            var response = new ApiResponse<T>();
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors)
                                               .Select(e => e.ErrorMessage)
                                               .ToList();

                response.Success = false;
                response.ErrorMessage = "Validation failed.";
                response.Errors = errors;
                response.StatusCode = (int)HttpStatusCode.BadRequest;
                response.Data = default(T);

                return BadRequest(response);
            }

            return null;
        }
    }
}
