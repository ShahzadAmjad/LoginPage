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
            if(ModelState.IsValid)
            {
                bool auth = _loginRepository.authenticate_User(login.Email, login.Password);
                if (auth)
                {
                    return View("Home");
                }
                else
                {
                    ViewBag.JavaScriptFunction = string.Format("ErrorMessage();");
                    return View("Login");
                }
            }
            else
            {
                return View();
            }           
        }
    }
}
