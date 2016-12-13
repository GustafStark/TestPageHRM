using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Webpage.Models;

namespace Webpage.Concrete
{
    public class Advertisement
    {
        
        public string Title { get; }
        public string AboutTheWork { get; }
        public DateTime EndDate { get; }
        public string PhoneNumber { get; }
        public string Email { get; }

        public bool Visable { get; }
        public string Author { get; }

        List<Experinces> Experinces { get; }

        public Advertisement()
        {

        }

        public Advertisement(string sTitle, string sAboutTheWork, DateTime xEndDate, string sPhoneNumber, string sEmail, bool bVisable, string sAuthur, List<Experinces> lxExperinces)
        {
            Title = sTitle;
            AboutTheWork = sAboutTheWork;
            EndDate = xEndDate;
            PhoneNumber = sPhoneNumber;
            Email = sEmail;
            Visable = bVisable;
            Author = sAuthur;
            Experinces = lxExperinces;

        }

    }
    public class Experinces
    {
        private WebpageContext db = new WebpageContext();
        public int Id { get; }
        public string Value { get; }
        public Experinces()
        {

        }

        private Experinces(int iId, string sValue)
        {
            Id = iId;
            Value = sValue;
        }
        
        public List<Experinces> GetExperinces()
        {
            List<Experinces> lxList = new List<Experinces>();
            foreach (var item in db.Experiences.ToList())
            {
                Experinces xExperince = new Experinces(item.ExperienceID, item.Value);
                lxList.Add(xExperince);
            }
            return lxList;
        }



    }
}