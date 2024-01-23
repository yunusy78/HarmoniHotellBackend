using System.Linq.Expressions;

namespace DataAccess.Abstract;

public interface IGenericRepository<T> where T : class, new()
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
    IQueryable<T> Where(Expression<Func<T, bool>> predicate);
    Task<bool> AddAsync(T entity);
    Task<bool> AddRangeAsync(IEnumerable<T> entities);
    Task<bool> Update(T entity);
    Task<bool> Remove(T entity);
    Task<bool> RemoveRange(IEnumerable<T> entities);
    
    
    
    
}