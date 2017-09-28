using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication29.Dto;
using WebApplication29.Models;

namespace WebApplication29.Controllers
{
    public class StudentsController : ApiController
    {
       
        
            private Studentcontext db;
            public StudentsController()
            {
                db = new Studentcontext();
            }

          public IEnumerable<StudentDto> GetMembers()
          {
              return db.stud1.ToList().Select(Mapper.Map<Studentviewmodel, StudentDto>);


          }
          public StudentDto GetMember(int id)
              {
                  var member = db.stud1.SingleOrDefault(c => c.StuId == id);
                  if (member == null)
                      throw new HttpResponseException(HttpStatusCode.NotFound);
                  return Mapper.Map<Studentviewmodel, StudentDto>(member);

              }
              [HttpPost]
              //  public MemberDto CreateMember(MemberDto memberDto)
              public IHttpActionResult Create(StudentDto memberDto)
              {
                  if (!ModelState.IsValid)
                      // throw new HttpResponseException(HttpStatusCode.BadRequest);
                      return BadRequest();
                  var member = Mapper.Map<StudentDto, Studentviewmodel>(memberDto);
                  db.stud1.Add(member);
                  db.SaveChanges();
                  memberDto.StuId = member.StuId;
                  return Created(new Uri(Request.RequestUri + "/" + member.StuId), memberDto);
                  //      return memberDto();
              }
              [HttpPut]
              public void UpdateMember(int id, StudentDto memberDto)
              {
                  if (!ModelState.IsValid)
                      throw new HttpResponseException(HttpStatusCode.BadRequest);
                  var memberInDb = db.Students.SingleOrDefault(c => c.StuId == id);
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
                  var memberInDb = db.stud1.SingleOrDefault(c => c.StuId == id);
                  if (memberInDb == null)
                      throw new HttpResponseException(HttpStatusCode.NotFound);
                  db.stud1.Remove(memberInDb);
                  db.SaveChanges();
              }
        
        
            //Add Action for GET // for Fetch data from database and return to the Client
          
            }
        
    
}
