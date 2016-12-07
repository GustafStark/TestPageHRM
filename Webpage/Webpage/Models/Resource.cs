using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webpage.Models
{
    public class Resource
    {
        public int ResourceID { get; set; }
        public string Culture { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}