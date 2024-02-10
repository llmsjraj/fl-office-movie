using Api.Business.DTOs;
using Api.Business.Repository.Data;

namespace Api.Business.Services
{
    public interface IActorService
    {
        Task<ApiResponse<List<Actor>>> GetByIdsAsync(IEnumerable<int> ids);
        Task<ApiResponse<List<Actor>>> GetAllAsync();
        Task<ApiResponse<Actor>> AddAsync(ActorDto movie);
        Task UpdateAsync(ActorDto movie);
        Task DeleteAsync(int id);
    }
}
