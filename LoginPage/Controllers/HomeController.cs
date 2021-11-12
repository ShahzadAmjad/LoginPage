using LoginPage.Models.Login;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginPage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILoginRepository _loginRepository;
        public HomeController(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        public IActionResult Index()
        {
            return View("Home");
        }
        [HttpGet]
        public ViewResult Login()
        {
            return View("Login");
        }
        [HttpPost]
        public ViewResult Login(Login login)
        {
            bool b= _loginRepository.authenticate_User(login.Email, login.Password);
            if(b)
            {
                return View("Home");
            }
            else
            {
                //return JavaScript("Callback()");
                //ViewBag.Message = "UserName or Password is Incorrect1";
                //TempData["Message"] = "UserName or Password is Incorrect2";
                ViewBag.JavaScriptFunction = string.Format("ErrorMessage();");

                return View("Login");
            }
        }
    }
}
