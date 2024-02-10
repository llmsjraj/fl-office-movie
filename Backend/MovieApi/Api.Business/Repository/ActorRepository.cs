using Api.Business.Repository.Data;

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

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Actor>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Actor> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Actor> UpdateAsync(Actor actor)
        {
            throw new NotImplementedException();
        }
    }
}
