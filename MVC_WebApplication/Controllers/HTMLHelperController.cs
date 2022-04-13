using Microsoft.AspNetCore.Mvc;

namespace MVC_WebApplication.Controllers
{
    public class HTMLHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
