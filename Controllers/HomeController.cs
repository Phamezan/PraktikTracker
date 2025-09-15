using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PraktikTracker.Models;

namespace PraktikTracker.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    
}
