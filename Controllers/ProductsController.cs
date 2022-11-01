using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using shoppingstore.Models;

namespace shoppingstore.Controllers;

public class ProductsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}