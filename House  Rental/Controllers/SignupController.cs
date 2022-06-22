using Microsoft.AspNetCore.Mvc;

namespace House__Rental.Controllers
{
    public class SignupController : Controller
    {
        public IActionResult Signup()
        {
            return View();
        }
    }
}
