using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SharpFlashCard.Models;

namespace SharpFlashCard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            GameRules gamerules = new GameRules();
            return View(gamerules);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}