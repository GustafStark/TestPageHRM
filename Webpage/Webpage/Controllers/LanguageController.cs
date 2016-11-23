using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Webpage.Controllers
{
    public class LanguageController : Controller
    {
     
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Change(String LanguageAbbrevation)
        {
            if (LanguageAbbrevation != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(LanguageAbbrevation);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(LanguageAbbrevation);

            }
            HttpCookie cookie = new HttpCookie("Language");
            cookie.Value = LanguageAbbrevation;
            Response.Cookies.Add(cookie);

            //return View("Index");
            return RedirectToAction("Index", "Home");
        }
        //public RedirectResult MainIndex()
        //{
        //    var xTest = new Controllers.HomeController();

        //    return xTest.Url.
        //}
    }
}