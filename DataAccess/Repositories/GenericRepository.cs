using System.Linq.Expressions;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
{
    protected readonly HarmonyDbContext _context;
    private readonly DbSet<T> _dbSet;
    
    public GenericRepository(HarmonyDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }
    
    public async Task<IEnumerable<T>> GetAllAsync()
    {
        var result = await _dbSet.AsNoTracking().ToListAsync();
        return result;
    }

    public async Task<T> GetByIdAsync(int id)
    {
        var result = await _dbSet.FindAsync(id);
        return result;
    }

    public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
    {
        var result = await _dbSet.AnyAsync(predicate);
        return result;
    }

    public IQueryable<T> Where(Expression<Func<T, bool>> predicate)
    {
        var result = _dbSet.Where(predicate);
        return result;
    }

    public async Task<bool> AddAsync(T entity)
    {
         await _dbSet.AddAsync(entity);
         return true;
         
    }

    public async Task<bool> AddRangeAsync(IEnumerable<T> entities)
    {
        await _dbSet.AddRangeAsync(entities);
        return true;
    }

    public Task<bool> Update(T entity)
    {
         _dbSet.Update(entity);
        return Task.FromResult(true);
    }

    public Task<bool> Remove(T entity)
    {
        _dbSet.Remove(entity);
        return Task.FromResult(true);
    }

    public Task<bool> RemoveRange(IEnumerable<T> entities)
    {
        _dbSet.RemoveRange(entities);
        return Task.FromResult(true);
    }
}