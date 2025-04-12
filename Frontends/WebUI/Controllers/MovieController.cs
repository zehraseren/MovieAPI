using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;

public class MovieController : Controller
{
    public IActionResult MovieList()
    {
        ViewBag.mainTitle = "FİLM LİSTESİ";
        ViewBag.navbarName = "ANA SAYFA";
        ViewBag.subtitle = "TÜM FİLMLER";
        return View();
    }
}
