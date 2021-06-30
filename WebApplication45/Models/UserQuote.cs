using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApplication45.Models
{
    public class UserQuote
    {
        [Display(Name = "Tours")]
        public TourList TourL { get; set; }
        public enum TourList
        {
            Ushaka,
            Cape_Of_Good_Hope,
            Apartheid_Museum,
            Gold_Reef_City_Theme_Park,
            Durban_Natural_Science_Museum,

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("UserID")]
        public int UserID { get; set; }


        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }


        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }


        [Display(Name = "Number of Adults")]
        [Range(0, 100)]
        public int NumAdults { get; set; }



        [Display(Name = "Number of Kids")]
        [Range(0, 100)]
        public int NumKids { get; set; }


        [Display(Name = "Departure Date")]
        [DataType(DataType.Date)]

        public DateTime DepartureDate { get; set; }


        [Display(Name = "Return Date")]
        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }

        [Display(Name = "Hotels")]
        public bool Hotels { get; set; }

        [Display(Name = "Tours")]
        public bool Tours { get; set; }

        [Display(Name = "Cruises")]
        public bool Cruises { get; set; }

        [Display(Name = "Flights")]
        public bool Flights { get; set; }
    }
}