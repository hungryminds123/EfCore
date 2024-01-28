using System.Linq.Expressions;

namespace Persistence.Interface
{
    public interface IGenericRepository<T> where T : class 
    {
        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();  // Read

        Task<T> Add(T entity);   // create (C)

        Task<T> Update(T entity);     // update (U)

        Task<T> Delete(int id);   // delete (D)

        Task<T> Find(Expression<Func<T, bool>> predicate);

        Task<IEnumerable<T>> FindAll(Expression<Func<T, bool>> predicate);  
    }
}
