using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.MovieDetailViewComponents;

public class _MovieDetailOverviewComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
