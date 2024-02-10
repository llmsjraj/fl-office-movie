namespace Api.Business.Repository.Data
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public ICollection<Actor> Actors { get; set; }
        public ICollection<MovieRating> Ratings { get; set; }
    }
}
