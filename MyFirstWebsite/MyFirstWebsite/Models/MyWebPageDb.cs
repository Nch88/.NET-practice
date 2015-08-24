using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyFirstWebsite.Models
{
    public class MyWebPageDb : DbContext
    {
        public MyWebPageDb() : base("name=DefaultConnection")
        {

        }

        public DbSet<Game> Games { get; set; }
        public DbSet<GameReview> Reviews { get; set; }
    }
}