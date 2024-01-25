using Microsoft.AspNetCore.Mvc;

namespace WebUI.Areas.Admin.ViewComponents.LayoutComponents;

[ViewComponent(Name = "_HeaderViewComponentPartial")]
public class HeaderViewComponentPartial :ViewComponent
{

    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}