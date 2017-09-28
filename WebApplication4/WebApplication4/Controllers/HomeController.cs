using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        cust custom;
        public HomeController()
        {
            custom = new cust();
        }
       public ActionResult Index()
        {
            var customList = new List<Customer>();/*  {
                    new Customer(){ ID=1, Name="John", Age = 18 , Phone=1354},
                    new Customer(){ID=2, Name="Steve", Age = 21, Phone=1354 },
                    new Customer(){ ID=3,Name="Bill", Age = 25,Phone=1203 },
                    new Customer(){ ID=4, Name="Ram", Age = 20,Phone=120 },
                    new Customer(){ ID=5, Name="Ron", Age = 31,Phone=1254 },
                    new Customer(){ ID=6, Name="Chris", Age = 17,Phone=0354 },
                    new Customer(){ ID=7, Name="Rob", Age = 19,Phone=1204 }
            };*/

            var customer = custom.Customers.ToList();
            return View(customer);
          //  return View(customList);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            custom.Customers.Add(customer);
            custom.SaveChanges(); 
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int ID)
        {
            var c = custom.Customers.Where(s => s.ID == ID).FirstOrDefault();

            return View(c);
        }

        [HttpPost]
        public ActionResult Edit(Customer c)
        {
            

            return RedirectToAction("Index");
        }
    }
}