using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Repositories;
using DataAccess.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace Business.Extensions;

public static class ScopedService
{
    public static void ContainerDependencies(this IServiceCollection services)

    {
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
        services.AddScoped<IUnitOfWork, UnitOfWork>();

    }
    
    
}
