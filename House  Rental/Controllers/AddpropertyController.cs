using House__Rental.Data;
using House__Rental.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Owin.BuilderProperties;

namespace House__Rental.Controllers
{
    public class AddpropertyController : Controller
    {

        public HouseRentalContext _context;
        public AddpropertyController(HouseRentalContext context)
        {
            _context = context;
        }
        public IActionResult PropertyDetails()
        {
            var propertyDetails =_context.PropertyRecords.ToList();
            return View(propertyDetails);

        }

        public IActionResult Addproperty()
        {
            return View();
        }
        [HttpPost]
         
        public async Task<IActionResult>addproperty(PropertyRecord pr)
        {
            if(ModelState.IsValid)
            {
                var p= new PropertyRecord()
                { 
                    Address = pr.Address,
                    PropertyType = pr.PropertyType,
                    Rentperiod = pr.Rentperiod,
                    AvaialbleDate = pr.AvaialbleDate,
                    Number_of_Bedrom=pr.Number_of_Bedrom,
                    Room_size=pr.Room_size, 
                    Total_Rent=pr.Total_Rent,
                    Deposite=pr.Deposite,
                    Prepaid_rent=pr.Prepaid_rent,
                    Extra_expense=pr.Extra_expense,
                    Owner_name=pr.Owner_name,
                    Owner_Email=pr.Owner_Email,
                    Owner_contact=pr.Owner_contact,
                };
                _context.PropertyRecords.Add(p);
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

        public IActionResult Remove(int Id)
        {
            var PR=_context.PropertyRecords.SingleOrDefault(p => p.Id == Id);
            _context.PropertyRecords.Remove(PR);
            _context.SaveChanges();
            TempData["msg"] = "Successfully Deletde";
            return RedirectToAction("PropertyDetails");

        }

        public IActionResult Edit(int Id)
        {
            var edit=_context.PropertyRecords.SingleOrDefault(p => p.Id == Id);
            return View(edit);
        }
        [HttpPost]
        public IActionResult Edit(PropertyRecord Pr)
        {
            if(ModelState.IsValid)
            {
                _context.PropertyRecords.Update(Pr);
                _context.SaveChanges();
                TempData["msg"] = "Update successfully";
                return RedirectToAction("PropertyDetails");
            }
            else
            {
                TempData["erreo"] = "Error occured";
                return View();
            }
        }
    }
}
