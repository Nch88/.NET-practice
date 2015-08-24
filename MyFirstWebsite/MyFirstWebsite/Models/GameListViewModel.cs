using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstWebsite.Models
{
    public class GameListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public int CountOfReviews { get; set; }
    }
}