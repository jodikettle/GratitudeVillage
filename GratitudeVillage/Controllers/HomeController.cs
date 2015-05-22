using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using GratitudeVillage.Models.ViewModels;

namespace GratitudeVillage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "What are you grateful for?";
            var list = new List<Gratitude>();

            return View(list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
