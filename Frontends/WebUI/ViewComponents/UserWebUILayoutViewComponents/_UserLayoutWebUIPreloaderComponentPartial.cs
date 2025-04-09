using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.UserWebUILayoutViewComponents;

public class _UserLayoutWebUIPreloaderComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
