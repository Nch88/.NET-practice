using MyFirstWebsite.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstWebsite.Controllers
{
    public class ReviewsController : Controller
    {
        //
        // GET: /Reviews/

        MyWebPageDb _db = new MyWebPageDb();

        public ActionResult Index([Bind(Prefix="id")] int gameId)
        {
            var game = _db.Games.Find(gameId);
            if (game != null)
            {
                return View(game);
            }
            return HttpNotFound();
        }

        [HttpGet]
        public ActionResult Create(int gameId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(GameReview review)
        {
            if (ModelState.IsValid)
            {
                _db.Reviews.Add(review);
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = review.GameId });
            }
            return View(review);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = _db.Reviews.Find(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Exclude="ReviewerName")]GameReview review)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(review).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = review.GameId });
            }
            return View(review);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}
