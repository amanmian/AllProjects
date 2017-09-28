using FluentApi4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FluentApi4.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }




        public string Edit(CustomerViewModel Model)
        {
            MCustomerContext context = new MCustomerContext();
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
            MCustomerContext context = new MCustomerContext();
            sort = (sort == null) ? "" : sort;
            int pageIndex = Convert.ToInt32(page) - 1;
            int pageSize = rows;

            //List import--->
            var customer = context.MCustomers.ToList();
            var order = context.MOrders.ToList();
            var product = context.MProducts.ToList();
            //List import--->

            #region <==Two Table Join==>

            var innerJoinQuery = customer.Join(order,
                                                   c => c.CustomerId,
                                                   m => m.CustomerId,
                                                   (c, m) => new {

                                                       c.CustomerName,
                                                       m.CustomerId,
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
                innerJoinQuery = innerJoinQuery.OrderByDescending(t => t.CustomerId);
                innerJoinQuery = innerJoinQuery.Skip(pageIndex * pageSize).Take(pageSize);
            }
            else
            {
                innerJoinQuery = innerJoinQuery.OrderBy(t => t.CustomerId);
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




    }
}