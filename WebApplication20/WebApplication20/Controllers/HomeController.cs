using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication20.Models;

namespace WebApplication18.Controllers
{
    public class HomeController : Controller
    {
        
        // GET: Home
        private Usercontext context = new Usercontext();
        public ActionResult Index()
        {
            var studentList = new List<User>();
            return View(context.Users.ToList());
        }


        [HttpGet]
        public ActionResult New()
        {

            var states = context.States.ToList();
            var countries = context.Countries.ToList();
            var viewModel = new Userviewmodel
            {
                user = new User(),
                List = states,
                List1= countries
            };

            return View("New", viewModel);

        }
        [HttpPost]
        public ActionResult New(User u)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new Userviewmodel
                {
                    user = u,
                    List = context.States.ToList(),
                    List1 = context.Countries.ToList()
                };

                return View("New", viewModel);
            }
            if(u.Id==0)
                context.Users.Add(u);
            else
            {
                State p1 = new State();

                Country c1 = new Country();
                var u1 = context.Users.Single(c => c.Id == u.Id);
                u1.Name = u.Name;
                u1.Email = u.Email;
                u1.Birthday = u.Birthday;
                u1.State = p1.state;
                u1.State = u.State;
                u1.Country = c1.country;
                u1.Country = u.Country;
                u1.Address = u.Address;

               



            }

         
            context.SaveChanges();
            return RedirectToAction("Index");

        }
      
    }
}