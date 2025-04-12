using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.UserWebUILayoutViewComponents;

public class _UserLayoutWebUIFooterComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
