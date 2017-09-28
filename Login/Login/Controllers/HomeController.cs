using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
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
        public ActionResult Register(User model)
        {
            var q = new UserContext();
            q.Users.Add(model);
            q.SaveChanges();

            return View();
        }
        public ActionResult Save()
        {
            return View();
        }
    }
}