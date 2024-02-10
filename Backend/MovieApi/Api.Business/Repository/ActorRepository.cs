using Api.Business.Repository.Data;
using Microsoft.EntityFrameworkCore;

namespace Api.Business.Repository
{
    public class ActorRepository : IActorRepository
    {
        private readonly DataContext _context;

        public ActorRepository(DataContext context)
        {
            _context = context;
        }

        public Task<Actor> AddAsync(Actor actor)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> AreActorIdsValid(IEnumerable<int> actorIds)
        {
            var existingActorIds = await _context.Actors
            .Where(actor => actorIds.Contains(actor.Id))
            .Select(actor => actor.Id)
            .ToListAsync();

            return existingActorIds.Count == actorIds.Count();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Actor>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Actor>> GetByIdsAsync(IEnumerable<int> ids)
        {
            return await _context.Actors
            .Where(actor => ids.Contains(actor.Id))
            .ToListAsync();
        }

        public Task<Actor> UpdateAsync(Actor actor)
        {
            throw new NotImplementedException();
        }
    }
}
