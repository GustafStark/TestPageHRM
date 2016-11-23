using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Webpage.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Posistion { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }

}