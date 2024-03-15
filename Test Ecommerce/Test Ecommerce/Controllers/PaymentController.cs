using Microsoft.AspNetCore.Mvc;

namespace Test_Ecommerce.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            ViewData["ForeignCutomer"] = "A foriegn customer logged";
            return View();
        }
    }
}
