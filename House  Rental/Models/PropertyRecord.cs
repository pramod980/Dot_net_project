using System.ComponentModel.DataAnnotations;

namespace House__Rental.Models
{
    public class PropertyRecord
    {
        [Key]
        public int Id { get; set; } 
        public string Address { get; set; }
        public string PropertyType { get; set; }    
        public string Rentperiod { get; set; }
        public string AvaialbleDate { get; set; } 
        public int Number_of_Bedrom { get; set; }
        public double Room_size { get; set; }   
        public int Total_Rent { get; set; }
        public int Deposite { get; set; }
        public int Prepaid_rent { get; set; }
        public int Extra_expense { get; set; }
        public string Owner_name { get; set; }
        public string Owner_Email { get; set; }
        public long Owner_contact { get; set; }

    }
}
