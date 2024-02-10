using Api.Business.DTOs;

namespace Api.Business.Services
{
    public interface IActorService
    {
        Task<ApiResponse<ActorDto>> GetByIdAsync(int id);
        Task<ApiResponse<ActorDto>> GetAllAsync();
        Task<ApiResponse<ActorDto>> AddAsync(ActorDto movie);
        Task UpdateAsync(ActorDto movie);
        Task DeleteAsync(int id);
    }
}
