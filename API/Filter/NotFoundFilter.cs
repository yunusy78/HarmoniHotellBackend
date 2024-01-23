using Business.Abstract;
using DtoLayer.CustomResponseDto;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace API.Filter;

public class NotFoundFilter<T> :IAsyncActionFilter where T:class,new()
{
    private readonly IGenericService<Room> _genericService;
    
    public NotFoundFilter(IGenericService<Room> genericService)
    {
        _genericService = genericService;
    }
    
    public  async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        var idValue = context.ActionArguments.Values.FirstOrDefault();
        if (idValue==null)
        {
            await next.Invoke();
            return;
        }
        var id =(int)idValue;
        var anyEntity = await _genericService.GetByIdAsync(id);
        if (anyEntity!=null)
        {
            await next.Invoke();
            return;
        }
        context.Result = new NotFoundObjectResult(CustomResponseDto<NoContentDto>.Fail("Not Found",404));
       
    }
}