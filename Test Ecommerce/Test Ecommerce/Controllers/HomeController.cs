using Microsoft.AspNetCore.Mvc;
using Test_Ecommerce.Model;

namespace Test_Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login loginUser)
        {       
            return View(loginUser.UserName);
        }
    }
}
