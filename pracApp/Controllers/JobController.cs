using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using pracApp.Models;

namespace pracApp.Controllers;

public class JobConroller : Controller
{
      public IActionResult Index(){
        return View();
    }
}
