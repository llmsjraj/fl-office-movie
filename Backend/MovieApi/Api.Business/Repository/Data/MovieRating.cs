namespace Api.Business.Repository.Data
{
    public class MovieRating
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int Rating { get; set; }
    }
}
