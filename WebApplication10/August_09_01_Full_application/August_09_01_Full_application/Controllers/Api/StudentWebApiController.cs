using August_09_01_Full_application.Dtos;
using August_09_01_Full_application.Models;
using AutoMapper;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;


namespace August_09_01_Full_application.Controllers.Api
{
    public class StudentWebApiController : ApiController
    {
        StudentWebTableContext context;
        
        public StudentWebApiController()
        {
            context = new StudentWebTableContext();
        }

        // GET /api/customers
        public IHttpActionResult GetStudents(string query = null)
        {
            
            var studentsQuery = context.student0002
                .Include(c => c.studentdetails0002);

            if (!String.IsNullOrWhiteSpace(query))
                studentsQuery = studentsQuery.Where(c => c.Stud_fname.Contains(query));

            var customerDtos = studentsQuery
                .ToList()
                .Select(Mapper.Map<StudentWebTable, StudentDto>);

            return Ok(customerDtos);
        }

        // GET /api/customers/1
        public IHttpActionResult GetStudent(int id)
        {
            var stud = context.student0002.SingleOrDefault(c => c.Stud_id == id);

            if (stud == null)
                return NotFound();

            return Ok(Mapper.Map<StudentWebTable, StudentDto>(stud));
        }

        // POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateStudent(StudentDto studentDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var student = Mapper.Map<StudentDto, StudentWebTable>(studentDto);
            context.student0002.Add(student);
            context.SaveChanges();

            studentDto.Stud_id = student.Stud_id;
            return Created(new Uri(Request.RequestUri + "/" + student.Stud_id), studentDto);
        }

        // PUT /api/customers/1
        [HttpPut]
        public IHttpActionResult UpdateStudent(int id, StudentDto studentDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var studentInDb = context.student0002.SingleOrDefault(c => c.Stud_id == id);

            if (studentInDb == null)
                return NotFound();

            Mapper.Map(studentDto, studentInDb);

            context.SaveChanges();

            return Ok();
        }

        // DELETE /api/customers/1
        [HttpDelete]
        public IHttpActionResult DeleteStudent(int id)
        {
            var studentInDb = context.student0002.SingleOrDefault(c => c.Stud_id == id);

            if (studentInDb == null)
                return NotFound();

            context.student0002.Remove(studentInDb);
            context.SaveChanges();

            return Ok();
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
