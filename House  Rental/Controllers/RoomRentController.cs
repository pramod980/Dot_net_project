using Microsoft.AspNetCore.Mvc;

namespace House__Rental.Controllers
{
    public class RoomRentController : Controller
    {
        public IActionResult RoomRent()
        {
            return View();
        }
    }
}
