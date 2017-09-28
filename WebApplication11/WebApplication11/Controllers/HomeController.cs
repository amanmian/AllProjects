using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Register(Student model)
        {
            var q = new StudentContext();
            q.Students.Add(model);
            q.SaveChanges();

            return View();
        }
        public ActionResult Save()
        {
            return View();
        }
    }
}