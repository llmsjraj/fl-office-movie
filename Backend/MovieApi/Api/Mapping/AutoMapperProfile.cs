using Api.Business.DTOs;
using Api.Business.Repository.Data;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace Api.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Movie, MovieDto>()
            .ForMember(dest => dest.Actors, opt => opt.MapFrom(src => src.Actors))
            .ForMember(dest => dest.MovieRatings, opt => opt.MapFrom(src => src.Ratings));

            CreateMap<MovieDto, Movie>()
                .ForMember(dest => dest.Actors, opt => opt.MapFrom(src => src.Actors))
                .ForMember(dest => dest.Ratings, opt => opt.MapFrom(src => src.MovieRatings));

            CreateMap<Actor, ActorDto>();
            CreateMap<MovieRating, MovieRatingDto>();
            CreateMap<CreateMovieDto, Movie>();
        }
    }
}
