using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CIS411_Wrestling_Project.Models;

namespace CIS411_Wrestling_Project.Controllers
{
    public class TimerController : Controller
    {
        private MatchDBContext db = new MatchDBContext();

        //
        // GET: /Timer/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Timer/Details/5

        public ActionResult Details(int id = 0)
        {
            Match match = db.Matches.Find(id);
            if (match == null)
            {
                return HttpNotFound();
            }
            return View(match);
        }

        //
        // GET: /Timer/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Timer/Create

        [HttpPost]
        public ActionResult Create(Match match)
        {
            if (ModelState.IsValid)
            {
                db.Matches.Add(match);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(match);
        }

        //
        // GET: /Timer/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Match match = db.Matches.Find(id);
            if (match == null)
            {
                return HttpNotFound();
            }
            return View(match);
        }

        //
        // POST: /Timer/Edit/5

        [HttpPost]
        public ActionResult Edit(Match match)
        {
            if (ModelState.IsValid)
            {
                db.Entry(match).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(match);
        }

        //
        // GET: /Timer/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Match match = db.Matches.Find(id);
            if (match == null)
            {
                return HttpNotFound();
            }
            return View(match);
        }

        //
        // POST: /Timer/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Match match = db.Matches.Find(id);
            db.Matches.Remove(match);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}