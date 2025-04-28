using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.MovieDetailViewComponents;

public class _MovieDetailRateComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
