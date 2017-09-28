using WebApplication27.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication27.Models
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }




        public string Edit(Customercontext Model)
        {
            Customercontext context = new Customercontext();
            string msg;
            try
            {
                if (ModelState.IsValid)
                {
                    context.Entry(Model).State = EntityState.Modified;
                    context.SaveChanges();
                    msg = "Saved Successfully";
                }
                else
                {
                    msg = "Validation data not successfully";
                }
            }
            catch (Exception ex)
            {
                msg = "Error occured:" + ex.Message;
            }
            return msg;
        }






        #region <==Trial Get JSON==>
        public JsonResult GetCustomers(string sidx, string sort, int page, int rows)
        {
            Customercontext context = new Customercontext();
            sort = (sort == null) ? "" : sort;
            int pageIndex = Convert.ToInt32(page) - 1;
            int pageSize = rows;

            //List import--->
            var customer = context.Customers.ToList();
            var order = context.Orders.ToList();
            var product = context.Products.ToList();
            //List import--->

            #region <==Two Table Join==>

            var innerJoinQuery = customer.Join(order,
                                                   c => c.CustomerId,
                                                   m => m.Customerid,
                                                   (c, m) => new {

                                                       c.CustomerName,
                                                       m.Customerid,
                                                       m.OrderId

                                                   });
            #endregion

            #region <==Thord Table Join==>

            //var threeTable = innerJoinQuery.Join(product,
            //                              c => c.OrderId,
            //                              m => m.OrderId,
            //                              (c, m) => new {

            //                                  c.CustomerId,
            //                                  c.CustomerName,
            //                                  c.OrderId,
            //                                  m.ProductId,
            //                                  m.ProductName

            //                              });

            #endregion



            int totalRecords = innerJoinQuery.Count();
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);
            if (sort.ToUpper() == "DESC")
            {
                innerJoinQuery = innerJoinQuery.OrderByDescending(t => t.Customerid);
                innerJoinQuery = innerJoinQuery.Skip(pageIndex * pageSize).Take(pageSize);
            }
            else
            {
                innerJoinQuery = innerJoinQuery.OrderBy(t => t.Customerid);
                innerJoinQuery = innerJoinQuery.Skip(pageIndex * pageSize).Take(pageSize);
            }
            var jsonData = new
            {
                total = totalPages,
                page,
                records = totalRecords,
                rows = innerJoinQuery
            };
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }
        #endregion
        

        [HttpPost]
        public string Create([Bind(Exclude = "Id")] Customer Model)
        {
            Customercontext db = new Customercontext();
            string msg;
            try
            {
                if (ModelState.IsValid)
                {
                    
                    db.Customers.Add(Model);
                    db.SaveChanges();
                    msg = "Saved Successfully";
                }
                else
                {
                    msg = "Validation data not successfully";
                }
            }
            catch (Exception ex)
            {
                msg = "Error occured:" + ex.Message;
            }
            return msg;
        }
        public string Edit(Customer Model)
        {
            Customercontext db = new Customercontext();
            string msg;
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(Model).State = EntityState.Modified;
                    db.SaveChanges();
                    msg = "Saved Successfully";
                }
                else
                {
                    msg = "Validation data not successfully";
                }
            }
            catch (Exception ex)
            {
                msg = "Error occured:" + ex.Message;
            }
            return msg;
        }
        public string Delete(string Id)
        {
            Customercontext db = new Customercontext();
            Customer student = db.Customers.Find(Id);
            db.Customers.Remove(student);
            db.SaveChanges();
            return "Deleted successfully";
        }
    }
}