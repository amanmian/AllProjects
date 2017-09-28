using Project4thAug.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Project4thAug.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Add()
        {
            InfoContext db = new InfoContext();

            ViewBag.StateList = db.StateList;
            var model = new Information();
            return View(model);
        }
        [HttpPost]
        public ActionResult Add(Information model)
        {
            InfoContext db = new InfoContext();

            if (ModelState.IsValid)
            {

                db.InfoList.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            ViewBag.StateList = db.StateList;
            return View(model);
        }
        public ActionResult GetData()
        {
            using (InfoContext db = new InfoContext())
            {
                var EmoloyeeData = db.InfoList.OrderBy(a => a.Name).ToList();
                return Json(new { data = EmoloyeeData }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]

        public ActionResult Edit()
        {
           


            return View();
        }
        [HttpPost]
        public ActionResult Edit(Information model)
        {
            var q = new InfoContext();

         
            if (ModelState.IsValid)
            {
                q.Entry(model).State = EntityState.Modified;
                q.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult FillCity(int state)
        {
            InfoContext db = new InfoContext();

            var cities = db.CityList.Where(c => c.StateId == state);
            return Json(cities, JsonRequestBehavior.AllowGet);
        }
    }
}