using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication13.Models;

namespace WebApplication13.Controllers
{
    public class HomeController : Controller
    {
        private Studentcontext context = new Studentcontext();
        public ActionResult Index()
        {
           return View(context.Students.ToList());
        }
       
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {

            if (string.IsNullOrEmpty(student.Name))
            {
                ModelState.AddModelError("Student_Name", "Name is required");
            }
            if (string.IsNullOrEmpty(student.Name))
            {
                ModelState.AddModelError("Student_Name", "Name is required");
            }

           
            if (string.IsNullOrEmpty(student.Email))
            {
                ModelState.AddModelError("Email", "Email is required");
            }
            if (string.IsNullOrEmpty(student.Qualification))
            {
                ModelState.AddModelError("Qualification", "This field is required");
            }
            if (ModelState.IsValid)
            {
                context.Students.Add(student);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }
    }
}