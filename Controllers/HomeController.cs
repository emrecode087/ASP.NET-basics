using basics.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace basics.Controllers
{
    // localhost ==> home/index
    // localhost/home ==>home/index
    // localhost/home/index ==>home/index
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

    }
}
