using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication45.Models
{
    public class AdminFlight
    {

        public Airline1 Airways { get; set; }
        public enum Airline1
        {
            Mango,
            SAA,
            British_Airways,
            Kulula,

        }
        [Display(Name = "From")]
        public From2 FROM { get; set; }
        public enum From2
        {
            King_Shaka_International,
            OR_Tambo,
            Lanseria,
            CapeTown_International,

        }
        [Display(Name = "To")]
        public To2 TO { get; set; }
        public enum To2
        {
            King_Shaka_International,
            OR_Tambo,
            Lanseria,
            CapeTown_International,

        }
        [Display(Name = "Seat Type")]
        public Class2 SeatType { get; set; }
        public enum Class2
        {
            Economy,
            Business,
            First,

        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]

        public int UserID { get; set; }

        [Display(Name = "Departure Date")]
        [DataType(DataType.Date)]
        public DateTime DepartureDate { get; set; }

        [Display(Name = "Departure Time")]

        public string DepartureTime { get; set; }

        //[Display(Name = "Return Flight")]
        //public bool Return_Flight { get; set; }

        //[Display(Name = "Return Date")]
        //[DataType(DataType.Date)]
        //public DateTime Return_Date { get; set; }


        //[Display(Name = "Return Time")]
        //public DateTime Return_Time { get; set; }




        //[Display(Name = "Return Date")]
        //[DataType(DataType.Date)]
        //public DateTime Return_Date { get; set; }

        //[Display(Name = "Return Time")]
        //[DataType(DataType.Time)]
        //public DateTime Return_Time { get; set; } 
        //[Display(Name = "Plane Name")]
        //public string Plane_Name { get; set; }

        [Display(Name = "Flight Duration")]
        public string Flight_Duration { get; set; }

        [Display(Name = "Flight Delay")]
        public bool FDelay { get; set; }
        [Display(Name = "Estimated Flight Delay")]
        public string Flight_Delay { get; set; }


        //[Display(Name = "Plane Capacity")]
        //public string Plane_Capacity { get; set; }
        public float Price { get; set; }

    }
}
