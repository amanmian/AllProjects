using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
       public  List<Customer> customers;

        public HomeController()
        {
          

        }
        public ActionResult Index()
        {
            List<Customer> customers = new List<Customer>();
            Customer c1 = new Customer
            {
                Id = 1,
                Name = "NEHA",
                Email = "nehadeori",
                Phone = 23457,
                Edit="Edit",
                Delete= "Delete",
                Details= "Details"

            };
            Customer c2 = new Customer
            {
                Id = 2,
                Name = "ANJALI",
                Email = "anjalideori",
                Phone = 234572,
                Edit = "Edit",
                Delete = "Delete",
                Details = "Details"
            };
            Customer c3 = new Customer
            {
                Id = 3,
                Name = "JOHN",
                Email = "johnkaty",
                Phone = 2345734,
                Edit = "Edit",
                Delete = "Delete",
                Details = "Details"
            };
            Customer c4 = new Customer
            {
                Id = 4,
                Name = "KARRY",
                Email = "karrych",
                Phone = 48976,
                Edit = "Edit",
                Delete = "Delete",
                Details = "Details"
            };
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);
            customers.Add(c4);
            return View(customers);
        
            
        }


        }
}