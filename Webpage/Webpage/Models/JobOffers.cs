using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Webpage.Controllers
{
    public class JobOffers
    {
        public int JobOffersID { get; set; }
        public string Title { get; set; }
        public string AboutTheWork { get; set; }
        public string Qualifications { get; set; }
        public string Email { get; set; }

        public bool Visable { get; set; }
        public string Author { get; set; }
    }
    public class JobOffersDBContext : DbContext
    {
        public DbSet<JobOffers> JobOfferss { get; set; }
    }
}