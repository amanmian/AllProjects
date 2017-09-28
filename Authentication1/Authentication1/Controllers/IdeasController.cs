using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Authentication1.Models;
using Microsoft.AspNet.Identity;

namespace Authentication1.Controllers
{
    [Authorize]
    public class IdeasController : ApiController
    {
        private IdeasContext db = new IdeasContext();

        // GET: api/Ideas
        [Authorize]
        public IQueryable<Idea> GetIdeas()
        {
            string userId = User.Identity.GetUserId();
            return db.Ideas.Where(idea=>idea.UserId==userId);
        }

        // GET: api/Ideas/5
        [ResponseType(typeof(Idea))]
        [Authorize]
        public IHttpActionResult GetIdea(int id)
        {
            Idea idea = db.Ideas.Find(id);
            if (idea == null)
            {
                return NotFound();
            }

            return Ok(idea);
        }

        // PUT: api/Ideas/5
        [ResponseType(typeof(void))]
        [Authorize]
        public IHttpActionResult PutIdea(int id, Idea idea)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != idea.Id)
            {
                return BadRequest();
            }

            db.Entry(idea).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IdeaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Ideas
        [ResponseType(typeof(Idea))]
        [Authorize]
        public IHttpActionResult PostIdea(Idea idea)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            string userId = User.Identity.GetUserId();
            idea.UserId = userId;
            db.Ideas.Add(idea);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = idea.Id }, idea);
        }

        // DELETE: api/Ideas/5
        [ResponseType(typeof(Idea))]
        [Authorize]
        public IHttpActionResult DeleteIdea(int id)
        {
            Idea idea = db.Ideas.Find(id);
            if (idea == null)
            {
                return NotFound();
            }

            db.Ideas.Remove(idea);
            db.SaveChanges();

            return Ok(idea);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool IdeaExists(int id)
        {
            return db.Ideas.Count(e => e.Id == id) > 0;
        }
    }
}