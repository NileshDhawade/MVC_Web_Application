using Microsoft.AspNetCore.Mvc;

namespace MVC_WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult FirstPage()
        {
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
