using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace House__Rental.Areas.Identity.Data;

// Add profile data for application users by adding properties to the House__RentalUser class
public class HouseRentalUser : IdentityUser
{

    public String FirstName { get; set; }
    public String LastName { get; set; }
}

