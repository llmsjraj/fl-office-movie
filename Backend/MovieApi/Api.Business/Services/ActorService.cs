using Api.Business.DTOs;
using Api.Business.Repository;
using AutoMapper;

namespace Api.Business.Services
{
    public class ActorService : IActorService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;
        public ActorService(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }

        public Task<ApiResponse<ActorDto>> AddAsync(ActorDto movie)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<ActorDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<ActorDto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ActorDto movie)
        {
            throw new NotImplementedException();
        }
    }
}
