using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;

public class MovieController : Controller
{
    public IActionResult MovieList()
    {
        ViewBag.title = "Film Listesi";
        ViewBag.navbarName = "Ana Sayfa";
        ViewBag.subtitle = "Tüm Filmler";
        return View();
    }
}
