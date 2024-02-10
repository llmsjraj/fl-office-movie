namespace Api.Business.DTOs
{
    /// <summary>
    /// Contains response error information
    /// </summary>
    public class ErrorResponse
    {
        /// <summary>
        /// HTTP error status code
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// User error message
        /// </summary>
        public string UserMessage { get; set; }
        /// <summary>
        /// Internal developer error message
        /// </summary>
        public string DeveloperMessage { get; set; }
        /// <summary>
        /// The innerException of the error.
        /// </summary>
        public string InnerExceptions { get; set; }
        /// <summary>
        /// The whole stackTrace of the exception.
        /// </summary>
        public string StackTrace { get; set; }
    }
}
