using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication17.Models;

namespace WebApplication17.Controllers
{
    public class HomeController : Controller
    {
        Employeecontext context;
        public HomeController()
        {
            context = new Employeecontext();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            using (Employeecontext db = new Employeecontext())
            {
                var CustomerData = db.Employees.OrderBy(a => a.Name).ToList();
                return Json(new { data = CustomerData }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {


            if (string.IsNullOrEmpty(employee.Name))
            {
                ModelState.AddModelError("Employee_Name", "Name is required");
            }
           


           
          
            if (ModelState.IsValid)
            {
                context.Employees.Add(employee);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }


    }



    }
