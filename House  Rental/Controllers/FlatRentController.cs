using Microsoft.AspNetCore.Mvc;

namespace House__Rental.Controllers
{
    public class FlatRentController : Controller
    {
        public IActionResult FlatRent()
        {
            return View();
        }
    }
}
