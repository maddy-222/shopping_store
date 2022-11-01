using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using shoppingstore.Models;

namespace shoppingstore.Controllers;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public RedirectResult Instagram(){
        return Redirect("https://www.instagram.com/");
    }
    public RedirectResult FaceBook(){
        return Redirect("https://www.facebook.com/");
    }
    public RedirectResult Twitter(){
        return Redirect("https://twitter.com/");
    }
}