using Microsoft.AspNetCore.Mvc;

namespace WebUI.Areas.Admin.ViewComponents.LayoutComponents;

[ViewComponent(Name = "_ScriptViewComponentPartial")]
public class ScriptViewComponentPartial :ViewComponent
{

    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}