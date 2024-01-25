using Microsoft.AspNetCore.Mvc;

namespace WebUI.Areas.Admin.ViewComponents.LayoutComponents;

[ViewComponent(Name = "_NavBarViewComponentPartial")]
public class NavBarViewComponentPartial :ViewComponent
{

    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}