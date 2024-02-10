namespace Api.Business.DTOs
{
    public class MovieRatingDto
    {
        /// <summary>
        /// Unique identifier for the movie rating.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The identifier of the movie associated with the rating.
        /// </summary>
        public int MovieId { get; set; }

        /// <summary>
        /// The rating given to the movie.
        /// </summary>
        public int Rating { get; set; }
    }
}
