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

        // Person onin = new Person();
        // onin.Id=1;
        // onin.Fullname = "nino abao";
        // onin.age = 20;

        Person Joman = new Person(){
            Id=1,
            Fullname="Joman  Lomusad",
            age=30,
        };
        Person onin = new Person(){
            Id=2,
            Fullname="Onin Abao",
            age=20,
        };
        Person Jake = new Person(){
            Id=3,
            Fullname="Nino Jake Catarata",
            age=30,
        };
        List<Person> listP = new List<Person>();
        listP.Add(Joman);
        listP.Add(onin);
        listP.Add(Jake);
        return View(listP);
    }

    public IActionResult Privacy()
    { 
       
        ViewBag.age = 30;
        // viewbag(Objec style)
        ViewBag.name = "nino";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
