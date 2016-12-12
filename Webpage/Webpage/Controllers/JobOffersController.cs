using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using Webpage.Concrete;
using Webpage.Models;

namespace Webpage.Controllers
{
    public class JobOffersController : Controller
    {
        private WebpageContext db = new WebpageContext();

        // GET: JobOffers
        public ActionResult Index()
        {
            return View(db.JobOffers.ToList());
        }

        // GET: JobOffers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobOffers jobOffers = db.JobOffers.Find(id);
            if (jobOffers == null)
            {
                return HttpNotFound();
            }
            return View(jobOffers);
        }

        // GET: JobOffers/Create
        public ActionResult Create()
        {

            Experinces xExperience = new Experinces();
            List<Experinces> lxExp = xExperience.GetExperinces();
            List<string> lsTest = new List<string>();
            foreach (var item in lxExp)
            {
                lsTest.Add(item.Value);
            }
            //ViewBag.Experience = xExperience.GetExperinces();
            ViewBag.Experience = lsTest;

            return View();
        }

        // POST: JobOffers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "JobOffersID,Title,AboutTheWork,EndDate,PhoneNumber,Email,Visable,Author")] JobOffers jobOffers)
        {
            if (ModelState.IsValid)
            {
                db.JobOffers.Add(jobOffers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jobOffers);
        }

        // GET: JobOffers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobOffers jobOffers = db.JobOffers.Find(id);
            if (jobOffers == null)
            {
                return HttpNotFound();
            }
            return View(jobOffers);
        }

        // POST: JobOffers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "JobOffersID,Title,AboutTheWork,EndDate,PhoneNumber,Email,Visable,Author")] JobOffers jobOffers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobOffers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jobOffers);
        }

        // GET: JobOffers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobOffers jobOffers = db.JobOffers.Find(id);
            if (jobOffers == null)
            {
                return HttpNotFound();
            }
            return View(jobOffers);
        }

        // POST: JobOffers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JobOffers jobOffers = db.JobOffers.Find(id);
            db.JobOffers.Remove(jobOffers);
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
