using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.UserWebUILayoutViewComponents;

public class _UserLayoutWebUILoginModalComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
