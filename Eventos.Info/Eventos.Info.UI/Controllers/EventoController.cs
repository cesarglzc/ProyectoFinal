using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eventos.Info.UI.Models;
using WebMatrix.WebData;

namespace Eventos.Info.UI.Controllers
{
    public class EventoController : Controller
    {
        private EventosdbEntities1 db = new EventosdbEntities1();
        //
        // GET: /Evento/

        public ActionResult Index()
        {
            Organizador organizador = db.Organizador.Where(x => x.Usuario == User.Identity.Name).First();
            int organizadorId = organizador.OrganizadorId;
           
            var evento = db.Evento.Include(e => e.Categoria).Include(e => e.Organizador).Where(x => x.OrganizadorId==organizadorId);
            return View(evento.ToList());
        }

        //
        // GET: /Evento/Details/5

        public ActionResult Details(int id = 0)
        {
            Evento evento = db.Evento.Find(id);
            if (evento == null)
            {
                return HttpNotFound();
            }
            return View(evento);
        }

        //
        // GET: /Evento/Create

        public ActionResult Create()
        {
            ViewBag.CategoriaId = new SelectList(db.Categoria, "CategoriaId", "Categoria1");
            ViewBag.OrganizadorId = new SelectList(db.Organizador, "OrganizadorId", "Nombre");
            return View();
        }

        //
        // POST: /Evento/Create

        [HttpPost]
        public ActionResult Create(Evento evento)
        {
            Organizador organizador = db.Organizador.Where(x => x.Usuario == User.Identity.Name).First();
            int organizadorId = organizador.OrganizadorId;
            evento.OrganizadorId = organizadorId;

            if (ModelState.IsValid)
            {
                db.Evento.Add(evento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoriaId = new SelectList(db.Categoria, "CategoriaId", "Categoria1", evento.CategoriaId);
            ViewBag.OrganizadorId = new SelectList(db.Organizador, "OrganizadorId", "Nombre", evento.OrganizadorId);
            return View(evento);
        }

        //
        // GET: /Evento/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Evento evento = db.Evento.Find(id);
            if (evento == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoriaId = new SelectList(db.Categoria, "CategoriaId", "Categoria1", evento.CategoriaId);
            ViewBag.OrganizadorId = new SelectList(db.Organizador, "OrganizadorId", "Nombre", evento.OrganizadorId);
            return View(evento);
        }

        //
        // POST: /Evento/Edit/5

        [HttpPost]
        public ActionResult Edit(Evento evento)
        {
            Organizador organizador = db.Organizador.Where(x => x.Usuario == User.Identity.Name).First();
            int organizadorId = organizador.OrganizadorId;
            evento.OrganizadorId = organizadorId;
           
            if (ModelState.IsValid)
            {
                db.Entry(evento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoriaId = new SelectList(db.Categoria, "CategoriaId", "Categoria1", evento.CategoriaId);
            ViewBag.OrganizadorId = new SelectList(db.Organizador, "OrganizadorId", "Nombre", evento.OrganizadorId);
            return View(evento);
        }

        //
        // GET: /Evento/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Evento evento = db.Evento.Find(id);
            if (evento == null)
            {
                return HttpNotFound();
            }
            return View(evento);
        }

        //
        // POST: /Evento/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Evento evento = db.Evento.Find(id);
            db.Evento.Remove(evento);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}