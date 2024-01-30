using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence.Interface;
using System.Linq.Expressions;

namespace Persistence.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly EFCoreLearningDBContext _dbContext;

        public GenericRepository(EFCoreLearningDBContext dbContext)
        {
            _dbContext = dbContext;
        }


        public Task<T> Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> Find(Expression<Func<T, bool>> predicate)
        {
            return await _dbContext.Set<T>().FirstOrDefaultAsync(predicate);
        }

        public async Task<IEnumerable<T>> FindAll(Expression<Func<T, bool>> predicate)
        {
            return await _dbContext.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<IEnumerable<T>> FindAll()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
