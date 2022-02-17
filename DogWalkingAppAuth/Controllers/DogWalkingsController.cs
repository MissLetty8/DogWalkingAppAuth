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
    [Authorize]
    public class DogWalkingsController : Controller
    {
        private DogWalkingDataContext db = new DogWalkingDataContext();

        // GET: DogWalkings
      
        public ActionResult Index()
        {
            return View(db.DogWalkings.ToList());
        }

        // GET: DogWalkings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DogWalking dogWalking = db.DogWalkings.Find(id);
            if (dogWalking == null)
            {
                return HttpNotFound();
            }
            return View(dogWalking);
        }

        // GET: DogWalkings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DogWalkings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WalkId,WalkDate,WalkerName,DogId,DogName,Distance,Affirmations")] DogWalking dogWalking)
        {
            if (ModelState.IsValid)
            {
                db.DogWalkings.Add(dogWalking);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dogWalking);
        }

        // GET: DogWalkings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DogWalking dogWalking = db.DogWalkings.Find(id);
            if (dogWalking == null)
            {
                return HttpNotFound();
            }
            return View(dogWalking);
        }

        // POST: DogWalkings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WalkId,WalkDate,WalkerName,DogId,DogName,Distance,Affirmations")] DogWalking dogWalking)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dogWalking).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dogWalking);
        }

        // GET: DogWalkings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DogWalking dogWalking = db.DogWalkings.Find(id);
            if (dogWalking == null)
            {
                return HttpNotFound();
            }
            return View(dogWalking);
        }

        // POST: DogWalkings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DogWalking dogWalking = db.DogWalkings.Find(id);
            db.DogWalkings.Remove(dogWalking);
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
