using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using House__Rental.Areas.Identity.Data;
using House__Rental.Data;
using Microsoft.AspNetCore.Identity;

namespace House__Rental.Models
{
    public class clientRecord
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
     
        public String Address { get; set; }
        public long Contact { get; set; }

      
    }
}
 