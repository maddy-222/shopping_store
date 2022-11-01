using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using shoppingstore.Models;

namespace shoppingstore.Controllers;

public class AboutController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}