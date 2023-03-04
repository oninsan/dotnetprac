using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using pracApp.Models;

namespace pracApp.Controllers;

public class AbaoController : Controller
{
    public IActionResult Index(){
        return View();
    }
}
