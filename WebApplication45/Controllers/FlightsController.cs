﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication45.Models;

namespace WebApplication45.Controllers
{
    public class FlightsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Flights
        public ActionResult Index()
        {
            return View(db.Flights.ToList());
        }
        public ActionResult Payment()
        {


            return View("Payment");
        }
        // GET: Flights/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Flight flight = db.Flights.Find(id);
            if (flight == null)
            {
                return HttpNotFound();
            }
            return View(flight);
        }

        // GET: Flights/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Flights/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FlightID,Airways,FROM,TO,SeatType,FirstName,LastName,Email,Departure_Date,DepartureTime,Return_Flight,Return_Date,Return_Time,Price,NumAdults,NumAChild,Seat_Type_Calc,Airline_Fee,ReturnTicket_Price,passenger_Cost,Add_Flight_Delay,Available_Seats,SEAT")] Flight flight)
        {
            if (ModelState.IsValid)
            {
                flight.Airline_Fee = flight.AirlineFee();
                flight.passenger_Cost = flight.passengerCost();
                flight.ReturnTicket_Price = flight.ReturnTicketPrice();
                flight.Seat_Type_Calc = flight.SeatTypeCalc();
                db.Flights.Add(flight);
                db.SaveChanges();
                return RedirectToAction("Payment");
            }

            return View(flight);
        }

        // GET: Flights/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Flight flight = db.Flights.Find(id);
            if (flight == null)
            {
                return HttpNotFound();
            }
            return View(flight);
        }

        // POST: Flights/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FlightID,Airways,FROM,TO,SeatType,FirstName,LastName,Email,Departure_Date,DepartureTime,Return_Flight,Return_Date,Return_Time,Price,NumAdults,NumAChild,Seat_Type_Calc,Airline_Fee,ReturnTicket_Price,passenger_Cost,Add_Flight_Delay,Available_Seats,SEAT")] Flight flight)
        {
            if (ModelState.IsValid)
            {
                db.Entry(flight).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(flight);
        }

        // GET: Flights/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Flight flight = db.Flights.Find(id);
            if (flight == null)
            {
                return HttpNotFound();
            }
            return View(flight);
        }

        // POST: Flights/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Flight flight = db.Flights.Find(id);
            db.Flights.Remove(flight);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
