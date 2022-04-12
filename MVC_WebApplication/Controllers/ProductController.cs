using Microsoft.AspNetCore.Mvc;
using MVC_WebApplication.Models;

namespace MVC_WebApplication.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {

            List<Product> products = new List<Product>()
            {
                new Product { id = 1, name = "HP Laptop", price=35000}

            };
            ViewBag.Prod = products;
            return View();
        }
    }
}
