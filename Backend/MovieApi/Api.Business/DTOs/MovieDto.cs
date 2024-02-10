using System.ComponentModel.DataAnnotations;

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

        /// <summary>
        /// Collection of actors associated with the movie.
        /// </summary>
        //public ICollection<ActorDto> Actors { get; set; }

        /// <summary>
        /// Collection of ratings given to the movie.
        /// </summary>
        //public ICollection<MovieRatingDto> Ratings { get; set; }
    }
}
