using System.Linq.Expressions;

namespace Business.Abstract;

public interface IGenericService <T> where T : class, new()
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
    IQueryable<T> Where(Expression<Func<T, bool>> predicate);
    Task<bool> AddAsync(T entity);
    Task<bool> AddRangeAsync(IEnumerable<T> entities);
    Task<bool> UpdateAsync(T entity);
    Task<bool> RemoveAsync(T entity);
    Task<bool> RemoveRangeAsync(IEnumerable<T> entities);
}