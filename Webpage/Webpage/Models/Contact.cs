using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Webpage.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        [NotMapped]
        public HttpPostedFileBase File { get; set; }
        public string ImagePath { get; set; }
        [Required]
        public string Name { get; set; }
        public string Posistion { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }

}