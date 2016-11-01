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
        //public static string ActionLinkWithImage(this HtmlHelper html,string imgSrc, string actionName)
        //{
        //    UrlHelper xUrlHelper = new UrlHelper(html.ViewContext.RequestContext);
        //    string sImageUrl = xUrlHelper.Content(imgSrc);
        //    TagBuilder xTagBuilder = new TagBuilder("img");
        //    xTagBuilder.MergeAttribute("src", sImageUrl);
        //    string sImage = xTagBuilder.ToString(TagRenderMode.Normal);
        //    string sUrl = xUrlHelper.Action(actionName);

        //    TagBuilder xTabBuilderSecound = new TagBuilder("a") { InnerHtml = sImage };
        //    xTabBuilderSecound.MergeAttribute("href", sUrl);

        //       return xTabBuilderSecound.ToString(TagRenderMode.Normal);
        //}
    }
}