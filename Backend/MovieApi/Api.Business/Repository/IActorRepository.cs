using Api.Business.Repository.Data;

namespace Api.Business.Repository
{
    public interface IActorRepository
    {
        Task<Actor> GetByIdAsync(int id);
        Task<List<Actor>> GetAllAsync();
        Task AddAsync(Actor actor);
        Task UpdateAsync(Actor actor);
        Task DeleteAsync(int id);
    }
}
