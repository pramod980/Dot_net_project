using Microsoft.AspNetCore.Mvc;

namespace House__Rental.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
