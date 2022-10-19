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
using Datos;

namespace PymesBackend.Controllers
{
    public class ArticulosFamiliasController : ApiController
    {
        private PymesEntities db = new PymesEntities();

        // GET: api/ArticulosFamilias
        public IQueryable<ArticulosFamilia> GetArticulosFamilias()
        {
            return db.ArticulosFamilias;
        }

        // GET: api/ArticulosFamilias/5
        [ResponseType(typeof(ArticulosFamilia))]
        public IHttpActionResult GetArticulosFamilia(int id)
        {
            ArticulosFamilia articulosFamilia = db.ArticulosFamilias.Find(id);
            if (articulosFamilia == null)
            {
                return NotFound();
            }

            return Ok(articulosFamilia);
        }

        // PUT: api/ArticulosFamilias/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutArticulosFamilia(int id, ArticulosFamilia articulosFamilia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != articulosFamilia.IdArticuloFamilia)
            {
                return BadRequest();
            }

            db.Entry(articulosFamilia).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticulosFamiliaExists(id))
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

        // POST: api/ArticulosFamilias
        [ResponseType(typeof(ArticulosFamilia))]
        public IHttpActionResult PostArticulosFamilia(ArticulosFamilia articulosFamilia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ArticulosFamilias.Add(articulosFamilia);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = articulosFamilia.IdArticuloFamilia }, articulosFamilia);
        }

        // DELETE: api/ArticulosFamilias/5
        [ResponseType(typeof(ArticulosFamilia))]
        public IHttpActionResult DeleteArticulosFamilia(int id)
        {
            ArticulosFamilia articulosFamilia = db.ArticulosFamilias.Find(id);
            if (articulosFamilia == null)
            {
                return NotFound();
            }

            db.ArticulosFamilias.Remove(articulosFamilia);
            db.SaveChanges();

            return Ok(articulosFamilia);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ArticulosFamiliaExists(int id)
        {
            return db.ArticulosFamilias.Count(e => e.IdArticuloFamilia == id) > 0;
        }
    }
}