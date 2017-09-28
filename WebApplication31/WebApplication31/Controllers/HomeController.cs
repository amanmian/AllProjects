using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebApplication31.Models;

namespace WebApplication31.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        Personcontext db = new Personcontext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
       
        public ActionResult Index(Person upload, HttpPostedFileBase file)
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
                string imagepath = "~/images/ + newpath";
                upload.length = imagepath;
                db.Persons.Add(upload);
                db.SaveChanges();
            }
            TempData["Success"] = "Upload successful";
            return RedirectToAction("Index");
        }
    }
}