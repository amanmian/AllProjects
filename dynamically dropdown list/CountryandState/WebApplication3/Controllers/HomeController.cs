using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private DetailContext context = new DetailContext();
     
        public ActionResult Index()
        {
            var studentList = new List<Detail>();
            return View(context.Details.ToList());
            //  return View();
        }

        [HttpGet]
        public ActionResult New()
        {
            var membershipTypes1 = context.Infos.ToList();
            var membershipTypes2 = context.Infi.ToList();
            var viewModel = new DetailVM
            {
                detail = new Detail(),
                List = membershipTypes1,
                List2= membershipTypes2
            };

            return View("New", viewModel);
        }
        [HttpPost]
        public ActionResult New(Detail detail)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new DetailVM
                {
                    detail = detail,
                    List = context.Infos.ToList(),
                    List2=context.Infi.ToList()
                };

                return View("New", viewModel);
            }
            if (detail.Id == 0)
                context.Details.Add(detail);
            else
            {
                
                 State m1 = new State();
                Country c1 = new Country();
                var customerInDb = context.Details.Single(c => c.Id == detail.Id);
                customerInDb.Name = detail.Name;
                customerInDb.Email = detail.Email;
                customerInDb.DateOfBirth = detail.DateOfBirth;
                customerInDb.State = m1.StateName;
                customerInDb.State = detail.State;
                customerInDb.Country = c1.CountryName;
                customerInDb.Country = detail.Country;
                customerInDb.Address = detail.Address;




               
            }
            context.SaveChanges();


            return RedirectToAction("Index");

        }
    }
}