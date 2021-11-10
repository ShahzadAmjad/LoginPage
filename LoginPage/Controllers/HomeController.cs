using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginPage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Home");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View("Login");
        }
        //[HttpPost]
        //public ViewResult Login()
        //{
        //    return View("Login");
        //}
    }
}
