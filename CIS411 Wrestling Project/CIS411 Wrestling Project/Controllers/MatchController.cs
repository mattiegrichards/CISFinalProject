using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CIS411_Wrestling_Project.Repositories;

namespace CIS411_Wrestling_Project.Controllers
{
    public class MatchController : Controller
    {

        private readonly MatchRepository _repository;

        public MatchController(MatchRepository repository)
        {
            _repository = repository;
        }

        //
        // GET: /Match/

        public ActionResult Index()
        {
            var matches = _repository.getAll();
            return View(matches);
        }

        //
        // GET: /Match/Details/5

        public ActionResult Details(int id)
        {
            return View();
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
        // GET: /Match/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Match/Edit/5

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
        // GET: /Match/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Match/Delete/5

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
