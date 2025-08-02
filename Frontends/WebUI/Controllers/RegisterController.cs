using System.Text;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using DtoLayer.UserRegisterDtos;

namespace WebUI.Controllers;

public class RegisterController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public RegisterController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [HttpGet]
    public IActionResult SignUp()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> SignUp(CreateUserRegisterDto curdto)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(curdto);
        StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var response = await client.PostAsync("https://localhost:44361/api/UserRegisters", content);
        if (response.IsSuccessStatusCode)
        {
            return RedirectToAction("SignIn", "Login");
        }

        ViewBag.error = "Kullanıcı kaydı oluşturulamadı. Lütfen tekrar deneyin.";
        return View();
    }
}
