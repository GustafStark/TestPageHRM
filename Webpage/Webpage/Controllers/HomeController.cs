using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webpage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Request.Cookies["Language"] != null)
            {
               var value = Request.Cookies["Language"].Value;
                if (value == "en")
                {
                    ViewBag.HeaderOneSub = "Technology & Environment Coalition";
                    ViewBag.HeaderTwo = "HRM will provide engineering services that give the client a technically and environmentally head start over its competitors ";
                    
                    ViewBag.FindOurExpertise = "Here you will find experts in";
                    ViewBag.HeaderThree = "Job satisfaction. Competence. Clarity";
                    ViewBag.HeaderThreeSub = "These three words are the backbone of our thinking at HRM.Det is the virtuous circle that provides personal development and sustainable profitability.";

                    ViewBag.HeaderFour = "Hybrid and electric vehicles";
                    ViewBag.HeaderFourSub = "No one has been able to avoid electric and hybrid cars is really going on. Major automotive manufacturers and fledgling niche business is now showing concept vehicles, prototypes and even production cars of both electric and hybrid cars.";

                    ViewBag.HeaderFive = "Focus on the future of technology";
                }
                else
                {
                    ViewBag.HeaderOneSub = "Teknik & Miljö i Samverkan";
                    ViewBag.HeaderTwo = "HRM skall erbjuda ingenjörstjänster som ger uppdragsgivaren ett tekniskt och miljömässigt försprång gentemot sina konkurrenter";
                   
                    ViewBag.FindOurExpertise = "Hos oss hittar du experter inom";
                    ViewBag.HeaderThree = "Arbetsglädje. Kompetens. Tydlighet";
                    ViewBag.HeaderThreeSub = "De här tre orden är ryggraden i hur vi tänker på HRM.Det är den goda cirkeln som ger personlig utveckling och hållbar lönsamhet.";

                    ViewBag.HeaderFour = "Hybrid och elfordon";
                    ViewBag.HeaderFourSub = "Ingen har väl kunnat undgå att el- och hybridbilar verkligen är på gång. Stora fordonstillverkare och nystartade nischföretag visar nu konceptfordon, prototyper och till och med produktionsbilar av både elfordon och hybridbilar.";

                    ViewBag.HeaderFive = "Focus på framtidens teknik";
                }
            }
            else
            {
                ViewBag.HeaderOneSub = "Teknik & Miljö i Samverkan";
                ViewBag.HeaderTwo = "HRM skall erbjuda ingenjörstjänster som ger uppdragsgivaren ett tekniskt och miljömässigt försprång gentemot sina konkurrenter";
                ViewBag.FindOurExpertise = "Hos oss hittar du experter inom";
                ViewBag.HeaderThree = "Arbetsglädje. Kompetens. Tydlighet";
                ViewBag.HeaderThreeSub = "De här tre orden är ryggraden i hur vi tänker på HRM.Det är den goda cirkeln som ger personlig utveckling och hållbar lönsamhet.";
                ViewBag.HeaderFour = "Hybrid och elfordon";
                ViewBag.HeaderFourSub = "Ingen har väl kunnat undgå att el- och hybridbilar verkligen är på gång. Stora fordonstillverkare och nystartade nischföretag visar nu konceptfordon, prototyper och till och med produktionsbilar av både elfordon och hybridbilar.";
                ViewBag.HeaderFive = "Focus på framtidens teknik";

            }
            ViewBag.HeaderOne = "HRM Engineering";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Inget vanligt konsultföretag";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Expertise()
        {
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