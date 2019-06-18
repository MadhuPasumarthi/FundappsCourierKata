using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FundAppsCourierKata.Models;

namespace FundAppsCourierKata.Controllers
{
    public class ParcelsController : Controller
    {
        private FundAppsCourierKataContext db = new FundAppsCourierKataContext();

        // GET: Parcels
        public ActionResult Index()
        {
            return View(db.Parcels.ToList());
        }

        // GET: Parcels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parcel parcel = db.Parcels.Find(id);
            if (parcel == null)
            {
                return HttpNotFound();
            }
            return View(parcel);
        }

        // GET: Parcels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Parcels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ParcelId,ParcelSize,Dimension,deliveryCost")] Parcel parcel)
        {
            if (ModelState.IsValid)
            {
                db.Parcels.Add(parcel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parcel);
        }

        // GET: Parcels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parcel parcel = db.Parcels.Find(id);
            if (parcel == null)
            {
                return HttpNotFound();
            }
            return View(parcel);
        }

        // POST: Parcels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ParcelId,ParcelSize,Dimension,deliveryCost")] Parcel parcel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parcel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(parcel);
        }

        // GET: Parcels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parcel parcel = db.Parcels.Find(id);
            if (parcel == null)
            {
                return HttpNotFound();
            }
            return View(parcel);
        }

        // POST: Parcels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Parcel parcel = db.Parcels.Find(id);
            db.Parcels.Remove(parcel);
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
