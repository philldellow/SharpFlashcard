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
        public ActionResult Index(string answer = "", string cardAnswer = "")
        {
            GameRules check = new GameRules(answer, cardAnswer);
            return View(check);

            //GameRules gamerules = new GameRules();
            //return View(gamerules);
        }

        //public ActionResult Check([Bind(Include = "Question,Answer")] FlashCards card)
        //{
        //    if (ModelState.IsValid)
        //    {

        //        //db.Posts.Add(post);
        //        //db.SaveChanges();
        //        //return RedirectToAction("Index");
        //    }

        //    return View("Index");
        //}

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
