using MyFirstWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstWebsite.Controllers
{
    public class PicturesController : Controller
    {
        //
        // GET: /Images/

        [ChildActionOnly]
        public ActionResult BestImage()
        {
            var bestImage = from r in _images
                            orderby r.Rating descending
                            select r;

            return PartialView("_Picture", bestImage.First());
        }

        public ActionResult Index()
        {
            var model =
                from r in _images
                orderby r.Id
                select r;

            return View(model);
        }

        //
        // GET: /Images/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Images/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Images/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Images/Edit/5

        public ActionResult Edit(int id)
        {
            var review = _images.Single(r => r.Id == id);

            return View(review);
        }

        //
        // POST: /Images/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var review = _images.Single(r => r.Id == id);
            if (TryUpdateModel(review))
            {
                //Could save to DB
                return RedirectToAction("Index");
            }
            return View(review);
        }

        //
        // GET: /Images/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Images/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        static List<Image> _images = new List<Image>
        {
            new Image 
            {
                Id = 1,
                Path = "/Images/Fat_unicorn.jpg",
                Description = "A fat unicorn",
                Rating = 5
            },
            new Image 
            {
                Id = 2,
                Path = "/Images/unicorn_cat.jpg",
                Description = "A unicat",
                Rating = 5
            },
            new Image 
            {
                Id = 3,
                Path = "/Images/tormentLogo.png",
                Description = "The torment logo",
                Rating = 5
            },
            new Image 
            {
                Id = 4,
                Path = "/Images/tormentLogoClean.png",
                Description = "A clean version of the torment logo",
                Rating = 5
            }
        };
    }
}
