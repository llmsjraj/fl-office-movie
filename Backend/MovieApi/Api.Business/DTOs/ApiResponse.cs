namespace Api.Business.DTOs
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public string ErrorMessage { get; set; }
        public List<string> Errors { get; set; }
        public int StatusCode { get; set; }
    }
}
