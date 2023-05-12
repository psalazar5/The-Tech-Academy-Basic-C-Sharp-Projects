using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {           
            if (ModelState.IsValid)
            {
                var insureeAge = DateTime.Now.Year - insuree.DateOfBirth.Year;
                insuree.Quote = 50m;
                if(insureeAge <= 18) //If insuree is 18 years or under 
                {
                    insuree.Quote += 100;
                }
                if(insureeAge >= 19 && insureeAge <= 25) //if insuree is over 19 and to 25 
                {
                    insuree.Quote += 50;
                }
                if(insureeAge >= 26) //if insuree age is older or equal 26
                {
                    insuree.Quote += 25;
                }
                if(insuree.CarYear < 2000 || insuree.CarYear > 2015) //if caryear is before 2000 and caryear after 2015
                {
                    insuree.Quote += 25;
                }
                if(insuree.CarMake.ToLower() == "porsche") //if insuree carmake is equal to porsche 
                {
                    insuree.Quote += 25;
                }
                if(insuree.CarMake.ToLower() == "porsche") //Carmake Porsche and carmodel 911 carrera step.h
                {
                    insuree.Quote += 25;
                    if(insuree.CarModel.ToLower() == "911 carrera")
                    {
                        insuree.Quote += 50;
                    }
                }
      
                insuree.Quote += 10m * insuree.SpeedingTickets; //Add 10 to monthly total for every speeding ticket insuree has 

                if (insuree.DUI == true) //if insuree has DUI add 25% to total , 1.25 representing the whole * 25%
                {
                    insuree.Quote *= 1.25m;
                }
                if(insuree.CoverageType == true) //if its fullcoverage add 50% 
                {
                    insuree.Quote *= 1.50m;
                }

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
