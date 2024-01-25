using Microsoft.AspNetCore.Mvc;

namespace WebUI.Areas.Admin.ViewComponents.LayoutComponents;

[ViewComponent(Name = "_SideBarViewComponentPartial")]
public class SideBarViewComponentPartial :ViewComponent
{

    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}