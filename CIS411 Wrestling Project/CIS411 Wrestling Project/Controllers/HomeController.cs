using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CIS411_Wrestling_Project.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Index()
        {
            ViewBag.Message = "";
            ViewBag.PlayerName = "home test";
            ViewBag.AwayPlayerName = "";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "";

            return View();
        }
    }
}
