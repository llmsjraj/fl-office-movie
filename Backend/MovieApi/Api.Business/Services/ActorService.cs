using Api.Business.DTOs;
using Api.Business.Repository;
using Api.Business.Repository.Data;
using AutoMapper;

namespace Api.Business.Services
{
    public class ActorService : IActorService
    {
        private readonly IActorRepository _actorRepository;
        private readonly IMapper _mapper;
        public ActorService(IActorRepository actorRepository, IMapper mapper)
        {
            _actorRepository = actorRepository;
            _mapper = mapper;
        }

        public Task<ApiResponse<Actor>> AddAsync(ActorDto movie)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<List<Actor>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResponse<List<Actor>>> GetByIdsAsync(IEnumerable<int> ids)
        {
            var data = await _actorRepository.GetByIdsAsync(ids);
            bool exist = data.Any();
            return new ApiResponse<List<Actor>>()
            {
                Data = data,
                Success = exist,
                StatusCode = exist ? 200 : 400
            };
        }

        public Task UpdateAsync(ActorDto movie)
        {
            throw new NotImplementedException();
        }
    }
}
