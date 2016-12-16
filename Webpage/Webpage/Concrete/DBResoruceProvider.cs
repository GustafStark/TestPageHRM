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

            foreach (var item in db.Resources.ToList())
            {
                if (item.Page == sPage )
                {
                    lxResources.Add(item);
                }
            }
            return lxResources;
        }

        public List<Contact> GetContacts()
        {
            return db.Contact.ToList();
        }
        public void UpdateContact(string sName,string sPoistion, string sPhone,string sEmail, int id)
        {
            foreach (var item in db.Contact.ToList())
            {
                if (item.ContactId == id)
                {
                    db.Contact.Find(item.ContactId).Name = sName;
                    db.Contact.Find(item.ContactId).Posistion = sPoistion;
                    db.Contact.Find(item.ContactId).Phone = sPhone;
                    db.Contact.Find(item.ContactId).Email = sEmail;
                    db.SaveChanges();
                }
            }
        }
    }
}