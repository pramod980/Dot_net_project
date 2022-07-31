using House__Rental.Areas.Identity.Data;
using House__Rental.Data;
using House__Rental.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace House__Rental.Controllers
{
    public class BookNowController : Controller
    {
        public HouseRentalContext _context;
        public BookNowController(HouseRentalContext context)
        {
            _context = context;
        }

        public IActionResult BookNow()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> bookNowAsync(clientRecord cr)
        {
            if (ModelState.IsValid)
            {
                var e = new clientRecord()
                {
                    Name = cr.Name,
                    Address=cr.Address,
                    Contact=cr.Contact,
                };
                _context.books.Add(e);
                await _context.SaveChangesAsync();
                TempData["msg"] = "Saved";
                return View();

            }
            else
            {
                TempData["error"] = "Some error occur";
                return View();
            }

        }
    }
}
