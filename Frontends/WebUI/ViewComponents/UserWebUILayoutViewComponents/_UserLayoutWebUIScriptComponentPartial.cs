using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.UserWebUILayoutViewComponents;

public class _UserLayoutWebUIScriptComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
