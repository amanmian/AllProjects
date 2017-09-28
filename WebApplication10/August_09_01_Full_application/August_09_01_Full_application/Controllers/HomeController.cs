using August_09_01_Full_application.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace August_09_01_Full_application.Controllers
{
    public class HomeController : Controller
    {
        StudentWebTableContext context;
        public HomeController()
        {
            context = new StudentWebTableContext();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetData()
        {
            using (StudentWebTableContext db = new StudentWebTableContext())
            {
                var CustomerData = db.student0002.OrderBy(a => a.Stud_fname).ToList();
                return Json(new { data = CustomerData }, JsonRequestBehavior.AllowGet);
            }
        }
        /*public JsonResult GetStudents(string sidx, string sort, int page, int rows)
        {
           
            sort = (sort == null) ? "" : sort;
            int pageIndex = Convert.ToInt32(page) - 1;
            int pageSize = rows;

            var StudentList = context.StudentView.Select(
                    t => new
                    {
                        t.Stud_id,
                        t.Stud_fname,
                        t.Stud_lname,
                        t.Stud_std,
                        t.Stud_group,
                        t.Stud_cousre,
                        t.age,
                        t.Stud_area,
                        t.Stud_street,
                        t.Stud_city,
                        t.Stud_zipcode
                    });
            int totalRecords = StudentList.Count();
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);
            if (sort.ToUpper() == "DESC")
            {
                StudentList = StudentList.OrderByDescending(t => t.Stud_fname);
                StudentList = StudentList.Skip(pageIndex * pageSize).Take(pageSize);
            }
            else
            {
                StudentList = StudentList.OrderBy(t => t.Stud_fname);
                StudentList = StudentList.Skip(pageIndex * pageSize).Take(pageSize);
            }
            var jsonData = new
            {
                total = totalPages,
                page,
                records = totalRecords,
                rows = StudentList
            };
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public string Create([Bind(Exclude = "Id")] StudentViewModel Model)
        {
           
            string msg;
            try
            {
                if (ModelState.IsValid)
                {
                    //Model.Stud_fname = Guid.NewGuid().ToString();
                    context.StudentView.Add(Model);
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
        public string Edit(StudentViewModel Model)
        {
           
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
        public string Delete(string Id)
        {
            StudentViewModel student = context.StudentView.Find(Id);
            context.StudentView.Remove(student);
            context.SaveChanges();
            return "Deleted successfully";
        }*/
    }
}