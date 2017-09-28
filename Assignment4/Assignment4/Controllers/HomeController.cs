using Assignment4.Repository;
using Assignment4.Repository.Entity;
using Assignment4.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Assignment4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private Employeecontext db = new Employeecontext();

        // GET: Employee
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            ViewBag.StateList = db.StateList;
            var model = new Employee();
            return View(model);
        }

        // POST: Employees/Create
     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Phone,Email,MariStatus,State,City")] Employee employee, Employee upload, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {


                if (file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var guid = Guid.NewGuid().ToString();
                    var path = Path.Combine(Server.MapPath("~/images"), guid + fileName);
                    file.SaveAs(path);
                    string fl = path.Substring(path.LastIndexOf("\\"));
                    string[] split = fl.Split('\\');
                    string newpath = split[1];
                    string imagepath = "~/images/" + newpath;
                    upload.length = imagepath;
                    db.Employees.Add(upload);
                    db.SaveChanges();
                }
                TempData["Success"] = "Upload successful";


                return RedirectToAction("Index");
            }
            ViewBag.StateList = db.StateList;

            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            ViewBag.StateList = db.StateList;

            return View(employee);

        }

        // POST: Employees/Edit/5
     
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Phone,Email,MariStatus,State,City")]  Employee employee)
        {
            if (ModelState.IsValid)
            {

                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StateList = db.StateList;
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult FillCity(int state)
        {
            Employeecontext db = new Employeecontext();

            var cities = db.CityList.Where(c => c.StateId == state);
            return Json(cities, JsonRequestBehavior.AllowGet);
        }






    }
}

