using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Webpage.Interface;
using Webpage.Models;
using System.Linq;

namespace Webpage.Concrete
{
    public class DBResoruceProvider : IResourceProvider
    {
        private WebpageContext db = new WebpageContext();
        public object GetResource(string sName, string sCulture)
        {
            List<Resource> lxResources = new List<Resource>();
           
            lxResources = db.Resources.ToList();

            foreach (var item in lxResources)
            {
                if (item.Name == sName && item.Culture == sCulture )
                {
                    return item.Value;
                }  
            }
            return "";
        }
        public object UpdateResources(string sName, string sCulture, string sValue)
        {
            //Resource xResources = new Resource();

            foreach (var item in db.Resources.ToList())
            {
                if (item.Culture == sCulture && item.Name == sName)
                {
                    db.Resources.Find(item.ResourceID).Value = sValue;
                    db.SaveChanges();
                }
            }
            return "";
        }  
        public List<Resource> GetResource(string sPage)
        {
            List<Resource> lxResources = new List<Resource>();

            //lxResources = db.Resources.ToList();

            foreach (var item in db.Resources.ToList())
            {
                if (item.Page == sPage )
                {
                    lxResources.Add(item);
                }
            }
            return lxResources;
        }
       
    }
}