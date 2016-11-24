using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Webpage.Models;

namespace Webpage.Controllers
{
    public class JobOffers
    {
        public int JobOffersID { get; set; }
        public string Title { get; set; }
        public string AboutTheWork { get; set; }
        public DateTime EndDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public bool Visable { get; set; }
        public string Author { get; set; }

        public virtual ICollection<Qualification> Qualifications { get; set; }
        //public ICollection<string> Assigments { get; set; }

    }
    public class JobOffersDBContext : DbContext
    {
        public DbSet<JobOffers> JobOfferss { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Contact> Contacts { get; set; }

    }
    public class Qualification
    {
        public int QualificationID { get; set; }

        public int ExperienceID { get; set; }
        
        public int JobOffersID { get; set; }

        public virtual Experience Experience { get; set; }
       
        public virtual JobOffers JobOffers { get; set; }

    }
    public class Experience
    {
        public int ExperienceID { get; set; }

        public string Value { get; set; }

        public virtual ICollection<Qualification> Qualifications { get; set; }
    }
}

