using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapiproject.D;
using webapiproject.Models;

namespace webapiproject.Controllers
{
    public class StudentsController : ApiController
    {
        private Studentcontext db;
        public StudentsController()
        {
            db = new Studentcontext();
        }
        Student[] students = new Student[]
        {
            new Student { Id = 1, Fname = "Neha", Lname = "Devri", Email = "devri1995" },
            new Student { Id = 2, Fname = "Anjali", Lname = "Devri", Email = "devri2011" },
            new Student { Id = 3, Fname = "Himani", Lname = "Chauhan", Email = "himanich" }
        };

        public IEnumerable<Student> GetAllStudents()
        {
            return students;
        }

        public IHttpActionResult GetStudent(int id)
        {
            var student = students.FirstOrDefault((p) => p.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }
          public IHttpActionResult CreateMember(StudentDto memberDto)
           {
               if (!ModelState.IsValid)
                   // throw new HttpResponseException(HttpStatusCode.BadRequest);
                   return BadRequest();
               var member = Mapper.Map<StudentDto, Student>(memberDto);
               db.Students.Add(member);
               db.SaveChanges();
               memberDto.Id = member.Id;
               return Created(new Uri(Request.RequestUri + "/" + member.Id), memberDto);
               //      return memberDto();
           }
           [HttpPut]
           public void UpdateMember(int id, StudentDto studentDto)
           {
               if (!ModelState.IsValid)
                   throw new HttpResponseException(HttpStatusCode.BadRequest);
               var memberInDb = db.Students.SingleOrDefault(c => c.Id == id);
               if (memberInDb == null)
                   throw new HttpResponseException(HttpStatusCode.NotFound);
               Mapper.Map(studentDto, memberInDb);
               //memberInDb.MemName = member.MemName;
               //memberInDb.MemEmail = member.MemEmail;
               //memberInDb.MemAddress = member.MemAddress;
               db.SaveChanges();


           }
           [HttpDelete]
           public void DeleteMember(int id)
           {
               var memberInDb = db.Students.SingleOrDefault(c => c.Id == id);
               if (memberInDb == null)
                   throw new HttpResponseException(HttpStatusCode.NotFound);
               db.Students.Remove(memberInDb);
               db.SaveChanges();
           }
    }
}

