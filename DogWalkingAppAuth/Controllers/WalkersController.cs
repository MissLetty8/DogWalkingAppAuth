using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DogWalkingAppAuth.Models;

namespace DogWalkingAppAuth.Controllers
{
    public class WalkersController : Controller
    {
        private DogWalkingDataContext db = new DogWalkingDataContext();

        // GET: Walkers
        public ActionResult Index()
        {
            return View(db.Walkers.ToList());
        }

        // GET: Walkers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Walker walker = db.Walkers.Find(id);
            if (walker == null)
            {
                return HttpNotFound();
            }
            return View(walker);
        }

        // GET: Walkers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Walkers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WalkerID,Walker_Name,Role")] Walker walker)
        {
            if (ModelState.IsValid)
            {
                db.Walkers.Add(walker);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(walker);
        }

        // GET: Walkers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Walker walker = db.Walkers.Find(id);
            if (walker == null)
            {
                return HttpNotFound();
            }
            return View(walker);
        }

        // POST: Walkers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WalkerID,Walker_Name,Role")] Walker walker)
        {
            if (ModelState.IsValid)
            {
                db.Entry(walker).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(walker);
        }

        // GET: Walkers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Walker walker = db.Walkers.Find(id);
            if (walker == null)
            {
                return HttpNotFound();
            }
            return View(walker);
        }

        // POST: Walkers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Walker walker = db.Walkers.Find(id);
            db.Walkers.Remove(walker);
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
