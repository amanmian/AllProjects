using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication14.Models;

namespace WebApplication14.Controllers
{
    public class HomeController : Controller
    {
        private Customercontext context;
        public HomeController()
        {
            context = new Customercontext();
        }

        public ActionResult New()
        {

            var membershipTypes = context.Membershiptypes.ToList();
            var viewModel = new CustomerViewModel
            {
                Customer = new Customer(),
                MembershipTypes = membershipTypes
            };

            return View("New", viewModel);

        }
        [HttpPost]
        public ActionResult New(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerViewModel
                {
                    Customer = customer,
                    MembershipTypes = context.Membershiptypes.ToList()
                };

                return View("New", viewModel);
            }
            if (customer.Id == 0)
                context.Customers.Add(customer);
            else
            {
                Customer m1 = new Customer();
                var customerInDb = context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.Date_of_Birth = customer.Date_of_Birth;
             
         
                customer.MembershipType = m1.MembershipType;
                customerInDb.MembershipType = customer.MembershipType;


            }

            context.SaveChanges();

            return RedirectToAction("Index");

        }




    }
    }
