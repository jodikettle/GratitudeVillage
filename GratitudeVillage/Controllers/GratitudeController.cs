using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GratitudeVillage.Controllers
{
    public class GratitudeController : Controller
    {
        //
        // GET: /Gratitude/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Gratitude/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Gratitude/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Gratitude/Create

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
        // GET: /Gratitude/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Gratitude/Edit/5

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
        // GET: /Gratitude/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Gratitude/Delete/5

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
