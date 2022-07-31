using Microsoft.AspNetCore.Mvc;

namespace House__Rental.Controllers
{
    public class HouseRentController : Controller
    {
        public IActionResult HouseRent()
        {
            return View();
        }
    }
}
