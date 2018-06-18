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
using Api.Data;
using Api.Models;

namespace Api.Controllers
{
    public class AmigosController : ApiController
    {
        private Contexto _db = new Contexto();

        // GET: api/Amigos
        public IHttpActionResult GetAmigos()
        {
            var amigosIndb = _db.Amigos.Include(x => x.Estado).ToList();
            return Ok(amigosIndb);
        }

        // GET: api/Amigos/5
        [ResponseType(typeof(Amigo))]
        public IHttpActionResult GetAmigo(int id)
        {
            Amigo amigo = _db.Amigos.Find(id);
            if (amigo == null)
            {
                return NotFound();
            }

            return Ok(amigo);
        }

        // PUT: api/Amigos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAmigo(int id, Amigo amigo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != amigo.Id)
            {
                return BadRequest();
            }

            _db.Entry(amigo).State = EntityState.Modified;

            try
            {
                _db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmigoExists(id))
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

        // POST: api/Amigos
        [ResponseType(typeof(Amigo))]
        public IHttpActionResult PostAmigo(Amigo amigo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _db.Amigos.Add(amigo);
            _db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = amigo.Id }, amigo);
        }

        // DELETE: api/Amigos/5
        [ResponseType(typeof(Amigo))]
        public IHttpActionResult DeleteAmigo(int id)
        {
            Amigo amigo = _db.Amigos.Find(id);
            if (amigo == null)
            {
                return NotFound();
            }

            _db.Amigos.Remove(amigo);
            _db.SaveChanges();

            return Ok(amigo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AmigoExists(int id)
        {
            return _db.Amigos.Count(e => e.Id == id) > 0;
        }
    }
}