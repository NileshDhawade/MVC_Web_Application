using Microsoft.AspNetCore.Mvc;
using MVC_WebApplication.Models;

namespace MVC_WebApplication.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult EmpList()
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee { empId = 1, empName= "Nilesh", empSalary=35000},
                new Employee { empId = 2, empName= "Ganesh", empSalary=30000},
                new Employee { empId = 3, empName= "Rajesh", empSalary=36000}

            };
            ViewBag.employee = emp;
            return View();
        }
    }
}
