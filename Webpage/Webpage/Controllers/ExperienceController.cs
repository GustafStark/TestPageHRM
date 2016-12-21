using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webpage.ViewModel;
using Webpage.Models;

namespace Webpage.Controllers
{
    public class ExperienceController : Controller
    {
        WebpageContext db = new WebpageContext();
        // GET: Experience
        public ActionResult Index()
        {
            List<Experience> xExperience;
            List<JobOffers> xJobOffer;
            if (db.Experiences == null)
            {
                Experience x = new Experience();
                x.ExperienceID = 1;
                x.Value = "Wooo";

                xExperience = new List<Experience>();
                xExperience.Add(x);
            }
            else xExperience = db.Experiences.ToList();


            if (db.JobOffers == null)
            {
                JobOffers x = new JobOffers();
                x.Title = "Title";
                x.Author = "ME";


                xJobOffer = new List<JobOffers>();
                xJobOffer.Add(x);
            }
            else xJobOffer = db.JobOffers.ToList();

            var view = new JobbViewModel()
            {
                Experience = xExperience,
                JobOffersViewModle = xJobOffer
            };

            return View(view);
        }
    }
}