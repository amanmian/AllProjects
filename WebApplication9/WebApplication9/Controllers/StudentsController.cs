using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class StudentsController : ApiController
    {
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
     /*  public IHttpActionResult CreateMember(MemberDto memberDto)
        {
            if (!ModelState.IsValid)
                // throw new HttpResponseException(HttpStatusCode.BadRequest);
                return BadRequest();
            var member = Mapper.Map<MemberDto, Member>(memberDto);
            db.Members.Add(member);
            db.SaveChanges();
            memberDto.MemId = member.MemId;
            return Created(new Uri(Request.RequestUri + "/" + member.MemId), memberDto);
            //      return memberDto();
        }
        [HttpPut]
        public void UpdateMember(int id, MemberDto memberDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var memberInDb = db.Members.SingleOrDefault(c => c.MemId == id);
            if (memberInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Mapper.Map(memberDto, memberInDb);
            //memberInDb.MemName = member.MemName;
            //memberInDb.MemEmail = member.MemEmail;
            //memberInDb.MemAddress = member.MemAddress;
            db.SaveChanges();


        }
        [HttpDelete]
        public void DeleteMember(int id)
        {
            var memberInDb = db.Members.SingleOrDefault(c => c.MemId == id);
            if (memberInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            db.Members.Remove(memberInDb);
            db.SaveChanges();
        }*/
    }
}

