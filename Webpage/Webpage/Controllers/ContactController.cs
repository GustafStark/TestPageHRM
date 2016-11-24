using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webpage.Models
{
    public class ContactController : Controller
    {
        private WebpageContext db = new WebpageContext();
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact xContact)
        {
            if (xContact.File.ContentLength >0)
            {
                string sFileName = Path.GetFileName(xContact.File.FileName);
                string sPath = Path.Combine(Server.MapPath("~/images/Contact"), sFileName);
                Create(xContact);
                xContact.File.SaveAs(sPath);
            }
            return RedirectToAction("Index");
        }
        private void Create(Contact xContact)
        {
            if (db != null)
            {
                db.Contact.Add(xContact);
                db.SaveChanges();
            }
        }
    }
}