using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace WebApplication45.Models
{
    public class UserTour
    {
        [Display(Name = "Tour type")]
        public Tours1 TourType { get; set; }
        public enum Tours1
        {

            Ushaka,
            Cape_Of_Good_Hope,
            Apartheid_Museum,
            Gold_Reef_City_Theme_Park,
            Durban_Natural_Science_Museum,


        }
        Tour user = new Tour();
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int GuestID { get; set; }


        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Number of adults")]
        [Range(0, 100)]
        public int Num_Adults { get; set; }

        [Display(Name = "Number of Kids")]
        [Range(0, 100)]
        public int Num_Kids { get; set; }



        [Display(Name = "Tour Name")]
        public string Tour_Name { get; set; }

        public double Deposit { get; set; }
        public double Discount { get; set; }
        public int Total_Tickets { get; set; }
        public double Total_Cost { get; set; }
        public double GuestCost { get; set; }
        public double Tour_Cost { get; set; }

        public double TourCost()
        {
            double x = 0;
            if (TourType == Tours1.Ushaka)
            {
                x = ((user.UshakPrice * Num_Adults) + ((user.UshakPrice * 0.50) * Num_Kids));
            }
            else if (TourType == Tours1.Apartheid_Museum)
            {
                x = (user.AppMuseum * Num_Adults) + ((user.AppMuseum * Num_Kids) * 0.10);
            }
            else if (TourType == Tours1.Cape_Of_Good_Hope)
            {
                x = (user.GoodHope * Num_Adults) + ((user.GoodHope * Num_Kids) * 0.10);
            }
            else if (TourType == Tours1.Gold_Reef_City_Theme_Park)
            {
                x = (user.GoldReef * Num_Adults) + ((user.GoldReef * Num_Kids) * 0.10);
            }
            else if (TourType == Tours1.Durban_Natural_Science_Museum)
            {
                x = (user.DNS * Num_Adults) + ((user.DNS * Num_Kids) * 0.10);
            }
            return x;


        }


        public double deposit()
        {

            double deposit = 0;
            if (TourCost() <= 100)
            {
                deposit = TourCost() * 0.15;
            }
            else
                if (TourCost() > 100 && TourCost() <= 150)
            {
                deposit = TourCost() * 0.20;
            }
            else
                if (TourCost() > 150 && TourCost() <= 175)
            {
                deposit = TourCost() * 0.25;
            }
            else
                if (TourCost() > 175 && TourCost() <= 200)
            {
                deposit = TourCost() * 0.30;
            }
            else
                if (TourCost() > 200)
            {
                deposit = TourCost() * 0.40;
            }
            return deposit;

        }
        //public double Guest_Cost()
        //{
        //    double x = 0;
        //    x = (TourCost() * Num_Adults) + ((TourCost() * Num_Kids) / 0.50);
        //    return x;
        //}

        public double TotalCost()
        {
            double x = 0;

            {
                x = TourCost() + deposit() - discount();

                return x;
            }

        }
        public double discount()
        {
            double x = 0;
            if (numOfTickets() >= 4 && numOfTickets() <= 6)
            {
                x = TourCost() * 0.05;

            }
            else if (numOfTickets() > 6 && numOfTickets() <= 10)
            {
                x = TourCost() * 0.10;

            }
            else if (numOfTickets() > 10 && numOfTickets() <= 15)
            {
                x = TourCost() * 0.15;

            }
            else if (numOfTickets() > 15 && numOfTickets() <= 20)
            {
                x = TourCost() * 0.20;

            }
            else
            {
                x = 0;
            }
            return x;



        }
        public int numOfTickets()
        {
            int x = Num_Adults + Num_Kids;
            return x;
        }

    }
}