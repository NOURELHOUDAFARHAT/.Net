using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Boolean = System.Boolean;

namespace AM.ApplicationCore.domain
{
    public class Passenger
        
    {
        [DataType(DataType.Date)]
        [Display(Name ="Date of birth")]
        public DateTime Date { get; set; }
        // public int Id { get; set; }
        public DateTime BirthDate { get; set; }
        [Key]
        [StringLength(7)]
        [MinLength(3, ErrorMessage="Min 3 caracteres")]
        [MaxLength(25, ErrorMessage = "Max 25 caracteres")]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public string EmailAddress { get; set; }

        [RegularExpression("@[0-9]{8}")]
        public string TelNumber { get; set; }
        public string PassportNumber { get; set; }
        public ICollection<Flight> Flights { get; set; }

        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");
        }

        public Boolean CheckProfile(string first, string last, string email = null)
        {
            if (email != null)
                return FirstName == first && LastName == last && EmailAddress == email;
            else
                return FirstName == first && LastName == last;
        }
    }
}
