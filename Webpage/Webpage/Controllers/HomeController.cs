using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webpage.Concrete;
using Webpage.Models;

namespace Webpage.Controllers
{
    public class HomeController : Controller
    {
        private WebpageContext db = new WebpageContext();
        private DBResoruceProvider xDBProvider = new DBResoruceProvider();
        public ActionResult Index()
        {
            ViewBag.HeaderOne = xDBProvider.GetResource("HomeHeader", Request.Cookies["Language"].Value);
            ViewBag.HomeHeaderOneSub = xDBProvider.GetResource("HomeHeaderOneSub", Request.Cookies["Language"].Value);
            ViewBag.HeaderTwo = xDBProvider.GetResource("HomeTextOne", Request.Cookies["Language"].Value);
            ViewBag.FindOurExpertise = xDBProvider.GetResource("HomeTextTwo", Request.Cookies["Language"].Value);
            ViewBag.HeaderThree = xDBProvider.GetResource("HomeHeaderTwo", Request.Cookies["Language"].Value);
            ViewBag.HeaderThreeSub = xDBProvider.GetResource("HomeTextThree", Request.Cookies["Language"].Value);
            ViewBag.HeaderFour = xDBProvider.GetResource("HomeHeaderThree", Request.Cookies["Language"].Value);
            ViewBag.HeaderFourSub = xDBProvider.GetResource("HomeHeaderThreeText", Request.Cookies["Language"].Value);
            ViewBag.HeaderFive = xDBProvider.GetResource("HomeEnd", Request.Cookies["Language"].Value);

            return View();
        }

        public ActionResult About()
        {
            
            ViewBag.Message = "Inget vanligt konsultföretag";
            ViewBag.Text = xDBProvider.GetResource("Test", Request.Cookies["Language"].Value);
         

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View(db.Contact.ToList());
        }
        public ActionResult Expertise()
        {
            ViewBag.HeaderOne = xDBProvider.GetResource("ExpertiseHeaderOne", Request.Cookies["Language"].Value);
            ViewBag.SubOne = xDBProvider.GetResource("ExpertiseSubOne", Request.Cookies["Language"].Value);
            ViewBag.HeaderTwo = xDBProvider.GetResource("ExpertiseHeaderTwo", Request.Cookies["Language"].Value);
            ViewBag.SubTwo = xDBProvider.GetResource("ExpertiseSubTwo", Request.Cookies["Language"].Value);
            ViewBag.HeaderThree = xDBProvider.GetResource("ExpertiseHeaderThree", Request.Cookies["Language"].Value);
            ViewBag.SubThree = xDBProvider.GetResource("ExpertiseSubThree", Request.Cookies["Language"].Value);
            ViewBag.HeaderFour = xDBProvider.GetResource("ExpertiseHeaderFour", Request.Cookies["Language"].Value);
            ViewBag.SubFour = xDBProvider.GetResource("ExpertiseSubFour", Request.Cookies["Language"].Value);
            ViewBag.HeaderFive = xDBProvider.GetResource("ExpertiseHeaderFive", Request.Cookies["Language"].Value);
            ViewBag.SubFive = xDBProvider.GetResource("ExpertiseSubFive", Request.Cookies["Language"].Value);
            ViewBag.HeaderSix = xDBProvider.GetResource("ExpertiseHeaderSix", Request.Cookies["Language"].Value);
            ViewBag.SubSix = xDBProvider.GetResource("ExpertiseSubSix", Request.Cookies["Language"].Value);
            return View();
        }

        public ActionResult Ourwork()
        {
            var xImageFiles = new Webpage.Models.ImageModel();
            //Place holder data!
            xImageFiles.Images.Add("~/images/SlideShow/development.jpg");
            xImageFiles.Images.Add("~/images/SlideShow/11086.jpg");
            xImageFiles.Images.Add("~/images/SlideShow/EngineeringKids.jpg");
            return View(xImageFiles);
        }
        public ActionResult Career()
        {
           

            return View();
        }
        public ActionResult SoundAndEnviorment()
        {
            return View();
        }
    }
}