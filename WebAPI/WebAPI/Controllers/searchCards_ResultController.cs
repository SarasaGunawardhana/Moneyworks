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
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class searchCards_ResultController : ApiController
    {
        private moneyworksSearch db = new moneyworksSearch();

        // GET: api/searchCards_Result
        public IQueryable<searchCards_Result> GetsearchCards_Result()
        {
            return db.searchCards_Result;
        }

        // GET: api/searchCards_Result/5
        [ResponseType(typeof(searchCards_Result))]
        public IHttpActionResult GetsearchCards_Result(int id)
        {
            searchCards_Result searchCards_Result = db.searchCards_Result.Find(id);
            if (searchCards_Result == null)
            {
                return NotFound();
            }

            return Ok(searchCards_Result);
        }

        // PUT: api/searchCards_Result/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutsearchCards_Result(int id, searchCards_Result searchCards_Result)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != searchCards_Result.bankId)
            {
                return BadRequest();
            }

            db.Entry(searchCards_Result).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!searchCards_ResultExists(id))
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

        // POST: api/searchCards_Result
        [ResponseType(typeof(searchCards_Result))]
        public IHttpActionResult PostsearchCards_Result(searchCards_Result searchCards_Result)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.searchCards_Result.Add(searchCards_Result);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = searchCards_Result.bankId }, searchCards_Result);
        }

        // DELETE: api/searchCards_Result/5
        [ResponseType(typeof(searchCards_Result))]
        public IHttpActionResult DeletesearchCards_Result(int id)
        {
            searchCards_Result searchCards_Result = db.searchCards_Result.Find(id);
            if (searchCards_Result == null)
            {
                return NotFound();
            }

            db.searchCards_Result.Remove(searchCards_Result);
            db.SaveChanges();

            return Ok(searchCards_Result);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool searchCards_ResultExists(int id)
        {
            return db.searchCards_Result.Count(e => e.bankId == id) > 0;
        }
    }
}