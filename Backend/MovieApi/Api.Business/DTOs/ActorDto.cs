namespace Api.Business.DTOs
{
    public class ActorDto
    {
        /// <summary>
        /// Unique identifier for the actor.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the actor.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Collection of movies associated with the actor.
        /// </summary>
        public ICollection<MovieDto> Movies { get; set; }
    }
}
