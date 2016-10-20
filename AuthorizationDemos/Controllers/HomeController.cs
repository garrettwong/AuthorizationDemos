using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthorizationDemos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Angular");
        }

        public ActionResult Angular()
        {
            ViewBag.Title = "Angular";

            return View();
        }

        public ActionResult JQuery()
        {
            ViewBag.Title = "jQuery";

            return View();
        }

        // This is where the callback goes to
        public ActionResult Result()
        {
            return View();
        }
    }
}
