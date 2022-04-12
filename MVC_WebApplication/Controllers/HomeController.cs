using Microsoft.AspNetCore.Mvc;

namespace MVC_WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult FirstPage()
        {
            ViewData["Message"] = "this is my first mvc application";
            List<string> colors = new List<string>() { "red","green","white","orange"};
            ViewData["ColorList"] = colors;
            ViewBag.Colors = colors;
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
