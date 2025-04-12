using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.UserWebUILayoutViewComponents;

public class _UserLayoutWebUIHeroComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
