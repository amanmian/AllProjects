using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication21.Models;

namespace WebApplication21.Controllers
{
    public class HomeController : Controller
    {
        CustomerContext context;
        public HomeController()
        {
            context = new CustomerContext();
        }
        // GET: Home
        public ActionResult Index()
        {
        
            return View();
        }
        public ActionResult New()
        {
         
            var membershipTypes = context.MyDrops.ToList();
            var viewModel = new FormView
            {
                customer = new Customer(),
                List = membershipTypes
            };

            return View("New", viewModel);
            
        }
        [HttpPost]
        public ActionResult New(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new FormView
                {
                    customer = customer,
                    List = context.MyDrops.ToList()
                };

                return View("New", viewModel);
            }
            if (customer.Id == 0)
                context.Customers.Add(customer);
            else
            {
                MyDrop m1=new MyDrop();
                var customerInDb = context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.Email = customer.Email;
                customerInDb.PhnNum = customer.PhnNum;
                customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
                customer.MyDr = m1.state; 
                customerInDb.MyDr = customer.MyDr;


            }

            context.SaveChanges();

            return RedirectToAction("Index");
            
        }
    }
}