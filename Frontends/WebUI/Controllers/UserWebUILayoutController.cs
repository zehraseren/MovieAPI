using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class UserWebUILayoutController : Controller
    {
        public IActionResult UILayout()
        {
            return View();
        }
    }
}
