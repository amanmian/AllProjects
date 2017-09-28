using FluentApiNewappli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FluentApiNewappli.Controllers
{
    
        public class CustomersController : Controller
        {
            SalesContext objContext=new SalesContext();
           
            
            // GET: /Customers/
            public ActionResult Index()
            {
                var TblCustomers = objContext.TblCustomers.ToList();
                return View(TblCustomers);
            }
            public ActionResult Create()
            {
                var Customer = new Customer();
                return View(Customer);
            }
            [HttpPost]
            public ActionResult Create(Customer Cust)
            {
                objContext.TblCustomers.Add(Cust);
                objContext.SaveChanges();
                return RedirectToAction("Index");
            }
            public ActionResult Delete(int id)
            {
                var Cust = objContext.TblCustomers.Where(c => c.CustomerId == id).First();
                return View(Cust);
            }
            [HttpPost]
            public ActionResult Delete(int id, Customer Cust)
            {
                var Customer = objContext.TblCustomers.Where(c =>
                 c.CustomerId == id).First();
                if (Customer != null)
                {
                    objContext.TblCustomers.Remove(Customer);
                    objContext.SaveChanges();
                }
                return RedirectToAction("Index");
            }
        }
    }
