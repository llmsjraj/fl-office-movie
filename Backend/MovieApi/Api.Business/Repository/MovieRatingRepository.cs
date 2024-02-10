using Api.Business.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Business.Repository
{
    public class MovieRatingRepository : IMovieRatingRepository
    {
        private readonly DataContext _context;

        public MovieRatingRepository(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Task<MovieRating> AddAsync(MovieRating actor)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<MovieRating>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MovieRating> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MovieRating> UpdateAsync(MovieRating actor)
        {
            throw new NotImplementedException();
        }
    }
}
