namespace Api.Business.DTOs
{
    public class MovieDto
    {
        /// <summary>
        /// Unique identifier for the movie.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The title of the movie.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The year of release of the movie.
        /// </summary>
        public int Year { get; set; }

        public List<int>? ActorIds { get; set; }
    }
}
