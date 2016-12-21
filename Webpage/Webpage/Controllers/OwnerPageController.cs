using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webpage.Concrete;
using Webpage.Models;

namespace Webpage.Controllers
{
    public class OwnerPageController : Controller
    {
        private DBResoruceProvider xDBProvider = new DBResoruceProvider();
        public virtual ActionResult Index()
        {
            return View("EditPage");
        }
        
        public ActionResult EditPage()
        {
            return View();
        }
        public ActionResult EditStart()
        {          
            List<Resource> lxResources = xDBProvider.GetResource("Home");   
            ViewBag.GetPage = lxResources;
            return View();
        }
        public ActionResult EditAbout()
        {
            List<Resource> lxResources = xDBProvider.GetResource("About");
            ViewBag.GetPage = lxResources;
            return View();
        }
        public ActionResult EditExpertise()
        {
            List<Resource> lxResources = xDBProvider.GetResource("Expertise");
            ViewBag.GetPage = lxResources;
            return View();
        }
        public ActionResult EditCareer()
        {
            List<Resource> lxResources = xDBProvider.GetResource("Career");
            ViewBag.GetPage = lxResources;
            return View();
        }
        public ActionResult EditOurWork()
        {
            List<Resource> lxResources = xDBProvider.GetResource("Ourwork");
            ViewBag.GetPage = lxResources;
            return View();
        }
        public ActionResult EditContact()
        {
            List<Resource> lxResources = xDBProvider.GetResource("Contact");
            ViewBag.GetPage = lxResources;
            return View();
        }
        public ActionResult EditEducation()
        {
            return View("~/Views/OwnerPage/EditDepartment/Education.cshtml");
        }
        public ActionResult EditSoftware()
        {
            return View("~/Views/OwnerPage/EditDepartment/SoftwareAndElectonics.cshtml");
        }
        public ActionResult EditEnviormentQuality()
        {
            return View("~/Views/OwnerPage/EditDepartment/EnviormentQuality.cshtml");
        }
        public ActionResult EditEletricCars()
        {
            return View("~/Views/OwnerPage/EditDepartment/HybridAndEletricCars.cshtml");
        }
        public ActionResult EditMekanik()
        {
            return View("~/Views/OwnerPage/EditDepartment/Mecanic.cshtml");
        }
        public ActionResult EditSoundAndEnviorment()
        {
            return View("~/Views/OwnerPage/EditDepartment/SoundAndEnviorment.cshtml");
        }
        public ActionResult EditAccounts()
        {
            return View();
        }
        public ActionResult CreateNewPage()
        {
            return View("EditStart");
        }

        public ActionResult Update(string sName)
        {
            if (sName == null) return View("EditPage");
            List<Resource> lxResources = xDBProvider.GetResource(sName);
            foreach (var item in lxResources)
            {
                xDBProvider.UpdateResources(item.Name, item.Culture, Request[item.Name + item.Culture]);
            }
            
            return View("EditPage");

        }
    }
}