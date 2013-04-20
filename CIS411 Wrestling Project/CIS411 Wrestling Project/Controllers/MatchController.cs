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
    public class MatchController : Controller
    {
        private MatchDBContext db = new MatchDBContext();

        //
        // GET: /Match/

        public ActionResult Index()
        {
            return View(db.Matches.ToList());
        }

        //
        // GET: /Match/Details/5

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
        // GET: /Match/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Match/Create

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
        // GET: /Match/Edit/5

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
        // POST: /Match/Edit/5

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
        // GET: /Match/Delete/5

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
        // POST: /Match/Delete/5

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