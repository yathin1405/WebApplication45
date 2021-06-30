using System;
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
    public class UserToursController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: UserTours
        public ActionResult Index()
        {
            return View(db.UserTours.ToList());
        }
        public ActionResult Payment()
        {


            return View("Payment");
        }
        // GET: UserTours/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserTour userTour = db.UserTours.Find(id);
            if (userTour == null)
            {
                return HttpNotFound();
            }
            return View(userTour);
        }

        // GET: UserTours/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserTours/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GuestID,TourType,FirstName,LastName,Email,Num_Adults,Num_Kids,Tour_Name,Deposit,Discount,Total_Tickets,Total_Cost,GuestCost,Tour_Cost")] UserTour userTour)
        {
            if (ModelState.IsValid)
            {
                userTour.Discount = userTour.discount();
                userTour.Deposit = userTour.deposit();
                userTour.Total_Tickets = userTour.numOfTickets();
                userTour.Tour_Cost = userTour.TourCost();
                userTour.Total_Cost = userTour.TotalCost();
                db.UserTours.Add(userTour);
                db.SaveChanges();
                return RedirectToAction("Payment");
            }

            return View(userTour);
        }

        // GET: UserTours/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserTour userTour = db.UserTours.Find(id);
            if (userTour == null)
            {
                return HttpNotFound();
            }
            return View(userTour);
        }

        // POST: UserTours/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GuestID,TourType,FirstName,LastName,Email,Num_Adults,Num_Kids,Tour_Name,Deposit,Discount,Total_Tickets,Total_Cost,GuestCost,Tour_Cost")] UserTour userTour)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userTour).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userTour);
        }

        // GET: UserTours/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserTour userTour = db.UserTours.Find(id);
            if (userTour == null)
            {
                return HttpNotFound();
            }
            return View(userTour);
        }

        // POST: UserTours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserTour userTour = db.UserTours.Find(id);
            db.UserTours.Remove(userTour);
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
