using Newtonsoft.Json;
using DtoLayer.MovieDtos;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;

public class MovieController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public MovieController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IActionResult> MovieList()
    {
        ViewBag.mainTitle = "FİLM LİSTESİ";
        ViewBag.navbarName = "ANA SAYFA";
        ViewBag.subtitle = "TÜM FİLMLER";

        var client = _httpClientFactory.CreateClient();
        var response = await client.GetAsync("https://localhost:44361/api/Movies");
        if (response.IsSuccessStatusCode)
        {
            var data = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<ResultMovieDto>>(data);
            return View(result);
        }
        return View();
    }

    public async Task<IActionResult> MovieDetail(int id)
    {
        id = 0;
        return View();
    }
}
