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
        WebpageContext db = new WebpageContext();
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
    }
}