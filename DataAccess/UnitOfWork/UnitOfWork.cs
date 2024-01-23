using DataAccess.Concrete;

namespace DataAccess.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly HarmonyDbContext _context;
    
    public UnitOfWork(HarmonyDbContext context)
    {
        _context = context;
    }
    
    public async Task CommitAsync()
    {
       await _context.SaveChangesAsync();
    }

    public void Commit()
    {
        _context.SaveChanges();
    }
}