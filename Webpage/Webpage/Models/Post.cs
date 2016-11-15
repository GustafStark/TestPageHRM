using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Webpage.Controllers
{
    public class Post
    {
        public int PostID { get; set; }

        public string Title { get; set; }

        public string ImagePath { get; set; }

        public string ShortText { get; set; }
        public string LongTest { get; set; }

        public bool Visable { get; set; }
        public string Author { get; set; }

    }
    public class PostDbContest : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    } 
}