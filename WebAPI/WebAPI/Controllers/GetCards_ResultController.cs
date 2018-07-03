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
    public class GetCards_ResultController : ApiController
    {
        private moneyworksSearch db = new moneyworksSearch();

        // GET: api/GetCards_Result
        public IQueryable<GetCards_Result> GetGetCards_Result()
        {
            return db.GetCards_Result;
        }

        // GET: api/GetCards_Result/5
        [ResponseType(typeof(GetCards_Result))]
        public IHttpActionResult GetGetCards_Result(int id)
        {
            GetCards_Result getCards_Result = db.GetCards_Result.Find(id);
            if (getCards_Result == null)
            {
                return NotFound();
            }

            return Ok(getCards_Result);
        }

        // PUT: api/GetCards_Result/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGetCards_Result(int id, GetCards_Result getCards_Result)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != getCards_Result.bankId)
            {
                return BadRequest();
            }

            db.Entry(getCards_Result).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GetCards_ResultExists(id))
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

        // POST: api/GetCards_Result
        [ResponseType(typeof(GetCards_Result))]
        public IHttpActionResult PostGetCards_Result(GetCards_Result getCards_Result)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.GetCards_Result.Add(getCards_Result);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = getCards_Result.bankId }, getCards_Result);
        }

        // DELETE: api/GetCards_Result/5
        [ResponseType(typeof(GetCards_Result))]
        public IHttpActionResult DeleteGetCards_Result(int id)
        {
            GetCards_Result getCards_Result = db.GetCards_Result.Find(id);
            if (getCards_Result == null)
            {
                return NotFound();
            }

            db.GetCards_Result.Remove(getCards_Result);
            db.SaveChanges();

            return Ok(getCards_Result);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GetCards_ResultExists(int id)
        {
            return db.GetCards_Result.Count(e => e.bankId == id) > 0;
        }
    }
}