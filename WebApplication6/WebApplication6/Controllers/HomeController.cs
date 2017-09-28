using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        private Studentcontext context=new Studentcontext();
        public ActionResult Index()
        {
        
            return View(context.Students.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Create(Student customer)
        {
            context.Students.Add(customer);
            context.SaveChanges();

            return RedirectToAction("Index");

        }
        
    }
}