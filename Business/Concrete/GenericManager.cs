using System.Linq.Expressions;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Business.Concrete;

public class GenericManager<T> : IGenericService<T> where T : class, new()
{
    private readonly IGenericRepository<T> _genericRepository;
    private readonly IUnitOfWork _unitOfWork;
    
    public GenericManager(IGenericRepository<T> genericRepository, IUnitOfWork unitOfWork)
    {
        _genericRepository = genericRepository;
        _unitOfWork = unitOfWork;
    }
    
    public async Task<IEnumerable<T>> GetAllAsync()
    {
        var result =await _genericRepository.GetAllAsync();
        return result;
    }

    public async Task<T> GetByIdAsync(int id)
    {
       var result= await _genericRepository.GetByIdAsync(id);

       return result;

    }

    public async  Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
    {
        var result = await _genericRepository.AnyAsync(predicate);
        return result;
    }

    public  IQueryable<T> Where(Expression<Func<T, bool>> predicate)
    {
        var result = _genericRepository.Where(predicate);
        return result;
    }

    public async Task<bool> AddAsync(T entity)
    {
        await _genericRepository.AddAsync(entity);
        await _unitOfWork.CommitAsync();
        return true;
    }

    public async Task<bool> AddRangeAsync(IEnumerable<T> entities)
    {
        await _genericRepository.AddRangeAsync(entities);
        await _unitOfWork.CommitAsync();
        return true;
    }

    public async Task<bool> UpdateAsync(T entity)
    {
        await _genericRepository.Update(entity);
        await _unitOfWork.CommitAsync();
        return true;
    }

    public async Task<bool> RemoveAsync(T entity)
    {
        await _genericRepository.Remove(entity);
        await _unitOfWork.CommitAsync();    
        return true;
    }

    public async Task<bool> RemoveRangeAsync(IEnumerable<T> entities)
    {
        await _genericRepository.RemoveRange(entities);
        await _unitOfWork.CommitAsync();
        return true;
    }
}