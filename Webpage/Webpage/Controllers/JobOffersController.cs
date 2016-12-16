using System;
using System.Collections.Generic;

using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
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
            List<SelectListItem> xList = new List<SelectListItem>();
            List<Experinces> lxExp = xExperience.GetExperinces();

            for (int i = 0; i < lxExp.Count; i++)
            {
                xList.Add(new SelectListItem { Text = lxExp[i].Value, Value = lxExp[i].Id.ToString() });
            }
            ViewData["foorBarList"] = xList;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateTest()
        {
            Qualification xQualification = new Qualification();

            JobOffers xJobOffers = new JobOffers();
            xJobOffers.Title = Request["Title"];
            xJobOffers.EndDate = Request["EndDate"].AsDateTime();
            xJobOffers.PhoneNumber = Request["PhoneNumber"];
            xJobOffers.AboutTheWork = Request["AboutTheWork"];
            xJobOffers.Author = Request["Author"];
            xJobOffers.Visable = Request["Visable"].AsBool();

            Post xPost = new Post();

            xQualification.JobOffersID = db.JobOffers.Add(xJobOffers).JobOffersID;

            //string xList = Request["mySelect"];
            //string[] sSplit = xList.Split(',');

            //for (int i = 0; i < sSplit.Length; i++)
            //{
            //    xPost.Title = sSplit[i];
            //    db.Posts.Add(xPost);
            //}

            //foreach (var item in xList)
            //{
            //    xPost.Title = item.ToString();
            //}
            //var x = new List<string>();
            //foreach (string item in Request.Form.AllKeys)
            //{
            //    if (item.StartsWith("mySelect"))
            //    {
            //        x.Add(Request.Form[item]);

            //        for (int i = 0; i < y.Count; i++)
            //        {

            //        }
            //        xPost.Title = Request.Form[item];
            //        db.Posts.Add(xPost);
            //    }
            //}

            //foreach (var item in sName)
            //{

            //    xPost.Title = item;
            //    db.Posts.Add(xPost);
            //}
            List<string> x = ViewData["ListOfThings"] as List<string>;

            for (int i = 0; i < x.Count; i++)
            {
                xPost.Title = x[i];
                db.Posts.Add(xPost);
            }
            //xPost.Title = sName;
            //db.Posts.Add(xPost);

            xQualification.ExperienceID = 1;

            db.Qualifications.Add(xQualification);

            db.SaveChanges();
            return RedirectToAction("Index");
        }


        // POST: JobOffers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "JobOffersID,Title,AboutTheWork,EndDate,PhoneNumber,Email,Visable,Author")] JobOffers jobOffers)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.JobOffers.Add(jobOffers);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(jobOffers);
        //}

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
        public object AddToList()
        {

            return "";
        }
    }
}
