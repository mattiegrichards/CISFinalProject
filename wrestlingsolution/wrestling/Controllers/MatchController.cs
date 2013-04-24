using wrestling.core.Models;
using wrestling.core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace wrestling.Controllers
{
    public class MatchController : Controller
    {
        //
        // GET: /Phone/

        public ActionResult Index()
        {
            IServices service = new MatchService();
            ICollection<MatchModel> matches = service.listMatches();
            return View(matches);
        }

        //
        // GET: /Phone/Details/5

        public ActionResult Details(int id)
        {
            IServices service = new MatchService();
            return View(service.getMatchById(id));
        }

        //
        // GET: /Phone/Create

        public ActionResult Create()
        {
            IServices service = new MatchService();
            MatchModel match = new MatchModel();

            //Figure out how to create the dropdown list for the page
            //http://blinkingcaret.wordpress.com/2012/08/11/using-html-dropdownlistfor/

            //ViewBag.matchCd = new SelectList(service.getPhoneCds(), "matchCd", "matchCodeDescription", match.matchCd);
            return View(match);
        }

        //
        // POST: /Phone/Create

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
        // GET: /Phone/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Phone/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Phone/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Phone/Delete/5

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

    }
}