using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace WebApplication45.Models
{
    public class UserCruise
    {
        [Display(Name = "Ship Name")]
        public Ships1 Ship_name { get; set; }
        public enum Ships1
        {
            Princess_Cruises,
            Costa_Cruises,
            MSC_Cruises,
            Royal_Caribbean_Cruises,

        }

        [Display(Name = "From")]
        public From1 FROM { get; set; }
        public enum From1
        {
            Port_Elizabeth,
            Durban,
            Capetown,

        }

        [Display(Name = "To")]
        public To1 TO { get; set; }
        public enum To1
        {
            Port_Elizabeth,
            Durban,
            Capetown,

        }

        Cruise user = new Cruise();
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Display(Name = "Cruise ID")]
        public int CruiseID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        //[Display(Name = "Ship Name")]
        //public string Ship_Type { get; set; }

        [Display(Name = "Cruise Duration")]
        public string Cruise_Duration { get; set; }

        [Display(Name = "Number of Adults")]
        [Range(0, 100)]
        public int Num_Adults { get; set; }

        [Display(Name = "Number of Chidren")]
        [Range(0, 100)]
        public int Num_Kids { get; set; }


        //[Display(Name = "From")]
        //public string LocationFrom { get; set; }
        //[Display(Name = "TO")]
        //public string LocationTO { get; set; }

        [Display(Name = "Departure Date")]
        [DataType(DataType.Date)]
        public string Departure_Date { get; set; }


        //[Display(Name = "Departure Time")]
        //[DataType(DataType.Time)]
        //public DateTime DepartureTime { get; set; }







        public double Ship_Fee { get; set; }
        public double ShipFee()
        {
            double x = 0;
            if (Ship_name == Ships1.Princess_Cruises && FROM == From1.Capetown && TO == To1.Durban)
            {
                x = 450 * Num_Adults + ((450 * Num_Kids) * 0.50);
            }
            else if (Ship_name == Ships1.Princess_Cruises && FROM == From1.Capetown && TO == To1.Port_Elizabeth)
            {
                x = 550 * Num_Adults + ((550 * Num_Kids) * 0.50);
            }
            else if (Ship_name == Ships1.Princess_Cruises && FROM == From1.Durban && TO == To1.Port_Elizabeth)
            {
                x = 400 * Num_Adults + ((400 * Num_Kids) * 0.50);
            }
            else if (Ship_name == Ships1.Princess_Cruises && FROM == From1.Durban && TO == To1.Capetown)
            {
                x = 500 * Num_Adults + ((500 * Num_Kids) * 0.50);
            }
            else if (Ship_name == Ships1.Princess_Cruises && FROM == From1.Port_Elizabeth && TO == To1.Durban)
            {
                x = 650 * Num_Adults + ((650 * Num_Kids) * 0.50);
            }
            else if (Ship_name == Ships1.Princess_Cruises && FROM == From1.Port_Elizabeth && TO == To1.Capetown)
            {
                x = 600 * Num_Adults + ((600 * Num_Kids) * 0.50);
            }
            if (Ship_name == Ships1.MSC_Cruises && FROM == From1.Capetown && TO == To1.Durban)
            {
                x = 550 * Num_Adults + ((550 * Num_Kids) * 0.50);
            }
            else if (Ship_name == Ships1.MSC_Cruises && FROM == From1.Capetown && TO == To1.Port_Elizabeth)
            {
                x = 600 * Num_Adults + ((600 * Num_Kids) * 0.50);
            }
            else if (Ship_name == Ships1.MSC_Cruises && FROM == From1.Durban && TO == To1.Port_Elizabeth)
            {
                x = 450 * Num_Adults + ((450 * Num_Kids) * 0.50);
            }
            else if (Ship_name == Ships1.MSC_Cruises && FROM == From1.Durban && TO == To1.Capetown)
            {
                x = 550 * Num_Adults + ((550 * Num_Kids) * 0.50);
            }
            else if (Ship_name == Ships1.MSC_Cruises && FROM == From1.Port_Elizabeth && TO == To1.Durban)
            {
                x = 600 * Num_Adults + ((600 * Num_Kids) * 0.50);
            }
            else if (Ship_name == Ships1.MSC_Cruises && FROM == From1.Port_Elizabeth && TO == To1.Capetown)
            {
                x = 670 * Num_Adults + ((670 * Num_Kids) * 0.50);
            }
            if (Ship_name == Ships1.Costa_Cruises && FROM == From1.Capetown && TO == To1.Durban)
            {
                x = 550 * Num_Adults + ((550 * Num_Kids) * 0.50);
            }
            else if (Ship_name == Ships1.Costa_Cruises && FROM == From1.Capetown && TO == To1.Port_Elizabeth)
            {
                x = 575 * Num_Adults + ((575 * Num_Kids) * 0.50);
            }
            else if (Ship_name == Ships1.Costa_Cruises && FROM == From1.Durban && TO == To1.Port_Elizabeth)
            {
                x = 580 * Num_Adults + ((580 * Num_Kids) * 0.50);
            }
            else if (Ship_name == Ships1.Costa_Cruises && FROM == From1.Durban && TO == To1.Capetown)
            {
                x = 600 * Num_Adults + ((600 * Num_Kids) * 0.50);
            }
            else if (Ship_name == Ships1.Costa_Cruises && FROM == From1.Port_Elizabeth && TO == To1.Durban)
            {
                x = 680 * Num_Adults + ((680 * Num_Kids) * 0.50);
            }
            else if (Ship_name == Ships1.Costa_Cruises && FROM == From1.Port_Elizabeth && TO == To1.Capetown)
            {
                x = 675 * Num_Adults + ((675 * Num_Kids) * 0.50);
            }
            if (Ship_name == Ships1.Royal_Caribbean_Cruises && FROM == From1.Capetown && TO == To1.Durban)
            {
                x = 475 * Num_Adults + ((475 * Num_Kids) * 0.50);
            }
            else if (Ship_name == Ships1.Royal_Caribbean_Cruises && FROM == From1.Capetown && TO == To1.Port_Elizabeth)
            {
                x = 570 * Num_Adults + ((570 * Num_Kids) * 0.50);
            }
            else if (Ship_name == Ships1.Royal_Caribbean_Cruises && FROM == From1.Durban && TO == To1.Port_Elizabeth)
            {
                x = 450 * Num_Adults + ((450 * Num_Kids) * 0.50);
            }
            else if (Ship_name == Ships1.Royal_Caribbean_Cruises && FROM == From1.Durban && TO == To1.Capetown)
            {
                x = 550 * Num_Adults + ((550 * Num_Kids) * 0.50);
            }
            else if (Ship_name == Ships1.Royal_Caribbean_Cruises && FROM == From1.Port_Elizabeth && TO == To1.Durban)
            {
                x = 750 * Num_Adults + ((750 * Num_Kids) * 0.50);
            }
            else if (Ship_name == Ships1.Royal_Caribbean_Cruises && FROM == From1.Port_Elizabeth && TO == To1.Capetown)
            {
                x = 700 * Num_Adults + ((700 * Num_Kids) * 0.50);
            }
            return x;
        }
        public int TotalTickets;
        public int numOfTickets()
        {
            int x = Num_Adults + Num_Kids;
            return x;
        }

        public double Discount { get; set; }
        public double discount()
        {
            double x = 0;
            if (numOfTickets() >= 4 && numOfTickets() <= 6)
            {
                x = ShipFee() * 0.05;

            }
            else if (numOfTickets() > 6 && numOfTickets() <= 10)
            {
                x = ShipFee() * 0.10;

            }
            else if (numOfTickets() > 10 && numOfTickets() <= 15)
            {
                x = ShipFee() * 0.15;

            }
            else if (numOfTickets() > 15 && numOfTickets() <= 20)
            {
                x = ShipFee() * 0.20;

            }
            else
            {
                x = 0;
            }
            return x;



        }



        public double Total { get; set; }
        public double TotalCost()
        {
            return ShipFee() - discount();
        }
    }
}