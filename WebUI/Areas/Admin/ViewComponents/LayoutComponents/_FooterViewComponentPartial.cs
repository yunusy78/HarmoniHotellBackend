using Microsoft.AspNetCore.Mvc;

namespace WebUI.Areas.Admin.ViewComponents.LayoutComponents;

[ViewComponent(Name = "_FooterViewComponentPartial")]
public class FooterViewComponentPartial :ViewComponent
{

    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}