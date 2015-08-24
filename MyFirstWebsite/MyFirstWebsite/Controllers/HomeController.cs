using MyFirstWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstWebsite.Controllers
{
    public class HomeController : Controller
    {
        MyWebPageDb _db = new MyWebPageDb();
        public ActionResult Index(string searchTerm = null)
        {
            //var model =
            //    from r in _db.Games
            //    orderby r.Reviews.Average(review => review.Rating) descending
            //    select new GameListViewModel
            //    {
            //        Id = r.Id,
            //        Name = r.Name,
            //        Genre = r.Genre,
            //        Description = r.Description,
            //        Developer = r.Developer,
            //        Publisher = r.Publisher,
            //        CountOfReviews = r.Reviews.Count()
            //    };


            //Comprehension syntax
            var model =
                _db.Games
                .OrderBy(g => g.Reviews.Average(review => review.Rating))
                .Where(g => searchTerm == null || g.Name.StartsWith(searchTerm))
                .Take(10) //Only available in comprehension syntax
                .Select(g =>
                    new GameListViewModel
                    {
                        Id = g.Id,
                        Name = g.Name,
                        Genre = g.Genre,
                        Description = g.Description,
                        Developer = g.Developer,
                        Publisher = g.Publisher,
                        CountOfReviews = g.Reviews.Count()
                    }
                    );

            return View(model);
        }

        public ActionResult About()
        {
            var model = new AboutModel();
            model.Title = "About this site";
            model.Message = "This is my first website.";
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
