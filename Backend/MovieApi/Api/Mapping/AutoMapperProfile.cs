using Api.Business.DTOs;
using Api.Business.Repository.Data;
using AutoMapper;

namespace Api.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Actor, ActorDto>();
            CreateMap<Movie, MovieDto>();
            CreateMap<MovieRating, MovieRatingDto>();
        }
    }
}
