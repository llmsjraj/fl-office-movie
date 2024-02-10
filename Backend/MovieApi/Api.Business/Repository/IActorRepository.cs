using Api.Business.Repository.Data;

namespace Api.Business.Repository
{
    public interface IActorRepository
    {
        Task<Actor> GetByIdAsync(int id);
        Task<List<Actor>> GetAllAsync();
        Task<Actor> AddAsync(Actor actor);
        Task<Actor> UpdateAsync(Actor actor);
        Task DeleteAsync(int id);
    }
}
