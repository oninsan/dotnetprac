using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using pracApp.Models;

namespace pracApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // viewdata
        ViewData["count"] = 5;
        return View();
    }

    public IActionResult Privacy()
    { 
       
        ViewBag.age = 30;
        // viewbug(Objec style)
        ViewBag.name = "nino";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
