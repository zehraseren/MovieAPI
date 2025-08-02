using Microsoft.AspNetCore.Mvc;
using DtoLayer.UserRegisterDtos;

namespace WebUI.Controllers;

public class RegisterController : Controller
{
    [HttpGet]
    public IActionResult SignUp()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SignUp(CreateUserRegisterDto curdto)
    {
        return RedirectToAction("SignIn", "Login");
    }
}
