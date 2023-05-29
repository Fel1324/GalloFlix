using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GalloFlix.Models;

namespace GalloFlix.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Genre> genres = new()
        {
            new Genre()
            {
                Id = 1,
                Name = "Ação"
            },
            new Genre()
            {
                Id = 2,
                Name = "Terror"
            }
        };
        genres.Add(
            new Genre()
            {
                Id = 3,
                Name = "Drama"
            }
        );

        return View(genres);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
