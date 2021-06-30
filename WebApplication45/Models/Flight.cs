using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace WebApplication45.Models
{
    public class Flight
    {
        public Airline Airways { get; set; }
        public enum Airline
        {
            Mango,
            SAA,
            British_Airways,
            Kulula,

        }
        [Display(Name = "From")]
        public From FROM { get; set; }
        public enum From
        {
            King_Shaka_International,
            OR_Tambo,
            Lanseria,
            CapeTown_International,

        }
        [Display(Name = "To")]
        public To TO { get; set; }
        public enum To
        {
            King_Shaka_International,
            OR_Tambo,
            Lanseria,
            CapeTown_International,

        }
        [Display(Name = "Seat Type")]
        public Class SeatType { get; set; }
        public enum Class
        {
            Economy,
            Business,
            First,

        }



        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]

        public int FlightID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Departure Date")]
        [DataType(DataType.Date)]
        public DateTime Departure_Date { get; set; }

        [Display(Name = "Departure Time")]

        public string DepartureTime { get; set; }

        [Display(Name = "Return Flight")]
        public bool Return_Flight { get; set; }

        [Display(Name = "Return Date")]
        [DataType(DataType.Date)]
        public DateTime Return_Date { get; set; }


        [Display(Name = "Return Time")]
        public string Return_Time { get; set; }




        //[Display(Name = "Return Date")]
        //[DataType(DataType.Date)]
        //public DateTime Return_Date { get; set; }

        //[Display(Name = "Return Time")]
        //[DataType(DataType.Time)]
        //public DateTime Return_Time { get; set; } 
        //[Display(Name = "Plane Name")]
        //public string Plane_Name { get; set; }

        //[Display(Name = "Flight Duration")]
        //public string Flight_Duration { get; set; }

        //[Display(Name = "Flight Delay")]
        //public bool FDelay { get; set; }
        //[Display(Name = "Estimated Flight Delay")]
        //public string Flight_Delay { get; set; }


        //[Display(Name = "Plane Capacity")]
        //public string Plane_Capacity { get; set; }
        public float Price { get; set; }


        //[Display(Name = "Ticket Price")]
        //[Required(ErrorMessage = "Price Required")]
        //public float Price { get; set; }
        [Display(Name = "Number of Adults")]
        [Range(0, 100)]
        public int NumAdults { get; set; }
        [Display(Name = "Number of children")]
        [Range(0, 100)]
        public int NumAChild { get; set; }



        public double Seat_Type_Calc { get; set; }
        public double SeatTypeCalc()
        {
            double x = 0;
            if (SeatType == Class.First)
            {
                x = Price * 0.30;
            }

            else if (SeatType == Class.Business)
            {
                x = Price * 0.20;
            }
            else
            {
                x = 0;
            }
            return x;
        }

        public double Airline_Fee { get; set; }
        public double AirlineFee()
        {
            double x = 0;

            if (Airways == Airline.Mango && FROM == From.CapeTown_International && TO == To.King_Shaka_International)
            {
                x = Price + SeatTypeCalc();

            }
            else if (Airways == Airline.Mango && FROM == From.CapeTown_International && TO == To.Lanseria)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.Mango && FROM == From.CapeTown_International && TO == To.OR_Tambo)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.Mango && FROM == From.King_Shaka_International && TO == To.CapeTown_International)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.Mango && FROM == From.King_Shaka_International && TO == To.Lanseria)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.Mango && FROM == From.King_Shaka_International && TO == To.OR_Tambo)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.Mango && FROM == From.Lanseria && TO == To.King_Shaka_International)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.Mango && FROM == From.Lanseria && TO == To.CapeTown_International)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.Mango && FROM == From.Lanseria && TO == To.OR_Tambo)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.Mango && FROM == From.OR_Tambo && TO == To.King_Shaka_International)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.Mango && FROM == From.OR_Tambo && TO == To.CapeTown_International)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.Mango && FROM == From.OR_Tambo && TO == To.Lanseria)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.British_Airways && FROM == From.CapeTown_International && TO == To.King_Shaka_International)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.British_Airways && FROM == From.CapeTown_International && TO == To.Lanseria)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.British_Airways && FROM == From.CapeTown_International && TO == To.OR_Tambo)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.British_Airways && FROM == From.King_Shaka_International && TO == To.CapeTown_International)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.British_Airways && FROM == From.King_Shaka_International && TO == To.Lanseria)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.British_Airways && FROM == From.King_Shaka_International && TO == To.OR_Tambo)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.British_Airways && FROM == From.Lanseria && TO == To.King_Shaka_International)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.British_Airways && FROM == From.Lanseria && TO == To.CapeTown_International)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.British_Airways && FROM == From.Lanseria && TO == To.OR_Tambo)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.British_Airways && FROM == From.OR_Tambo && TO == To.King_Shaka_International)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.British_Airways && FROM == From.OR_Tambo && TO == To.CapeTown_International)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.British_Airways && FROM == From.OR_Tambo && TO == To.Lanseria)
            {
                x = Price + SeatTypeCalc();

            }

            if (Airways == Airline.Kulula && FROM == From.CapeTown_International && TO == To.King_Shaka_International)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.Kulula && FROM == From.CapeTown_International && TO == To.Lanseria)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.Kulula && FROM == From.CapeTown_International && TO == To.OR_Tambo)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.Kulula && FROM == From.King_Shaka_International && TO == To.CapeTown_International)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.Kulula && FROM == From.King_Shaka_International && TO == To.Lanseria)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.Kulula && FROM == From.King_Shaka_International && TO == To.OR_Tambo)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.Kulula && FROM == From.Lanseria && TO == To.King_Shaka_International)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.Kulula && FROM == From.Lanseria && TO == To.CapeTown_International)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.Kulula && FROM == From.Lanseria && TO == To.OR_Tambo)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.Kulula && FROM == From.OR_Tambo && TO == To.King_Shaka_International)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.Kulula && FROM == From.OR_Tambo && TO == To.CapeTown_International)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.Kulula && FROM == From.OR_Tambo && TO == To.Lanseria)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.SAA && FROM == From.CapeTown_International && TO == To.King_Shaka_International)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.SAA && FROM == From.CapeTown_International && TO == To.Lanseria)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.SAA && FROM == From.CapeTown_International && TO == To.OR_Tambo)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.SAA && FROM == From.King_Shaka_International && TO == To.CapeTown_International)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.SAA && FROM == From.King_Shaka_International && TO == To.Lanseria)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.SAA && FROM == From.King_Shaka_International && TO == To.OR_Tambo)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.SAA && FROM == From.Lanseria && TO == To.King_Shaka_International)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.SAA && FROM == From.Lanseria && TO == To.CapeTown_International)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.SAA && FROM == From.Lanseria && TO == To.OR_Tambo)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.SAA && FROM == From.OR_Tambo && TO == To.King_Shaka_International)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.SAA && FROM == From.OR_Tambo && TO == To.CapeTown_International)
            {
                x = Price + SeatTypeCalc();

            }
            if (Airways == Airline.SAA && FROM == From.OR_Tambo && TO == To.Lanseria)
            {
                x = Price + SeatTypeCalc();

            }
            return x;

        }
        public double ReturnTicket_Price { get; set; }
        public double ReturnTicketPrice()
        {
            double x = 0;


            if (SeatType == Class.Economy && Return_Flight == true)
            {
                x = (passengerCost() + (passengerCost() * 0.60));
            }
            else if (SeatType == Class.Business && Return_Flight == true)
            {
                x = (passengerCost() + passengerCost() * 0.60);
            }
            else if (SeatType == Class.First && Return_Flight == true)
            {
                x = (passengerCost() + passengerCost() * 0.60);
            }
            else if (SeatType == Class.Business)
            {
                x = passengerCost();
            }
            else if (SeatType == Class.Economy)
            {
                x = passengerCost();
            }
            else if (SeatType == Class.First)
            {
                x = passengerCost();
            }
            return x;
        }
        public double passenger_Cost { get; set; }
        public double passengerCost()
        {
            double x = 0;

            x = NumAdults * AirlineFee() + ((NumAChild * AirlineFee() * 0.50));
            return x;
        }
        public string Add_Flight_Delay { get; set; }
        //public string Delay()
        //{
        //    string x = " ";
        //    if (FDelay == true)
        //    {
        //        x = "Your Flight Has Been Delayed By" + FDelay;
        //    }
        //    else
        //    {
        //        x = "No Delay";
        //    }
        //    return x;
        //}
        public string Available_Seats { get; set; }
        public string Seat()
        {
            string x = " ";
            if (SEAT == SeatAvail.Available)
            {
                x = "Seats are available";
            }
            else
            {
                x = "No Seats available";
            }
            return x;
        }
        public SeatAvail SEAT { get; set; }
        public enum SeatAvail
        {
            Available,
            Unavailable,
        }



    }
}