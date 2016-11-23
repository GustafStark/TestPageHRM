using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Webpage.Controllers;
using Webpage.Models;

namespace Webpage.ViewModel
{
    public class JobbViewModel
    {
        public List<JobOffers> JobOffersViewModle {get; set;}
        public List<Experience> Experience { get; set; }
    }
}