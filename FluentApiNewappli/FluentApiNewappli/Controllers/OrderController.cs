using FluentApiNewappli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FluentApiNewappli.Controllers
{
    public class OrderController : Controller
    {
        public class OrdersController : Controller
        {
            SalesContext objContext;
            public OrdersController()
            {
                objContext = new SalesContext();
            }

            // 
            // GET: /Orders/
            public ActionResult Index()
            {
                var Orders = objContext.TblOrders.ToList();
                return View(Orders);
            }
            public ActionResult Create()
            {
                var Order = new Order();
                return View(Order);
            }
            [HttpPost]
            public ActionResult Create(Order ord)
            {
                objContext.TblOrders.Add(ord);
                objContext.SaveChanges();
                return RedirectToAction("Index");
            }
            public ActionResult Delete(int id)
            {
                var Order = objContext.TblOrders.Where(o => o.OrderId == id).First();
                return View(Order);
            }
            [HttpPost]
            public ActionResult Delete(int id, Order ord)
            {
                var Order = objContext.TblOrders.Where(o => o.OrderId == id).First();
                if (Order != null)
                {
                    objContext.TblOrders.Remove(Order);
                    objContext.SaveChanges();
                }
                return RedirectToAction("Index");
            }
        }
    }
}