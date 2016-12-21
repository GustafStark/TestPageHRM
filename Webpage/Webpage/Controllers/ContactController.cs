using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webpage.Concrete;

namespace Webpage.Models
{
    public class ContactController : Controller
    {
        private WebpageContext db = new WebpageContext();
        private DBResoruceProvider xDBResourceProvider = new DBResoruceProvider();
        // GET: Contact
        public ActionResult Index()
        {
            return View(db.Contact.ToList());
        }
        [HttpPost]
        public ActionResult Index(Contact xContact)
        {
            if (xContact != null)
            {
                if (xContact.File.ContentLength > 0)
                {
                    string sFileName = Path.GetFileName(xContact.File.FileName);
                    string sPath = Path.Combine(Server.MapPath("~/images/Contact"), sFileName);
                    Create(xContact, sFileName);
                    xContact.File.SaveAs(sPath);
                }
            }

            return RedirectToAction("Index");
        }
        private void Create(Contact xContact, string sFileName)
        {
            if (db != null)
            {
                xContact.ImagePath = xContact.File.FileName;
                db.Contact.Add(xContact);
                db.SaveChanges();
            }
        }
        public ActionResult Delete(int iId)
        {

            Contact xContact = db.Contact.Find(iId);
            db.Contact.Remove(xContact);
            db.SaveChanges();


            return RedirectToAction("Index");
        }


        public ActionResult Edit()
        {
            var x = Request["NumberForID"];
            if (x == "" || x == null) x = "5";
            xDBResourceProvider.UpdateContact(Request["sName"], Request["Posistion"], Request["Phone"], Request["Email"], int.Parse(x));
            return RedirectToAction("Index");

            //return View();
            //return RedirectToAction("Index");
        }
        [HttpPost]
        public void Editor(string Name, string Posistion, string Phone, string Email)
        {
            RedirectToAction("Index","Home");
        }

    }
}