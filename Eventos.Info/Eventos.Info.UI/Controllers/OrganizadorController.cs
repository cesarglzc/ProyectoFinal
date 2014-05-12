using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eventos.Info.UI.Models;

namespace Eventos.Info.UI.Controllers
{
    public class OrganizadorController : Controller
    {
        private EventosdbEntities1 db = new EventosdbEntities1();

        //
        // GET: /Organizador/

        public ActionResult Index()
        {
            return View(db.Organizador.ToList());
        }

        //
        // GET: /Organizador/Details/5

        public ActionResult Details(int id = 0)
        {
            Organizador organizador = db.Organizador.Find(id);
            if (organizador == null)
            {
                return HttpNotFound();
            }
            return View(organizador);
        }

        //
        // GET: /Organizador/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Organizador/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Organizador organizador)
        {
            if (ModelState.IsValid)
            {
                db.Organizador.Add(organizador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(organizador);
        }

        //
        // GET: /Organizador/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Organizador organizador1 = db.Organizador.Where(x => x.Usuario == User.Identity.Name).First();
            int organizadorId = organizador1.OrganizadorId;
            id = organizadorId;

            Organizador organizador = db.Organizador.Find(id);
            if (organizador == null)
            {
                return HttpNotFound();
            }
            return View(organizador);
        }

        //
        // POST: /Organizador/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Organizador organizador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(organizador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index","Evento");
            }
            return View(organizador);
        }

        //
        // GET: /Organizador/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Organizador organizador = db.Organizador.Find(id);
            if (organizador == null)
            {
                return HttpNotFound();
            }
            return View(organizador);
        }

        //
        // POST: /Organizador/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Organizador organizador = db.Organizador.Find(id);
            db.Organizador.Remove(organizador);
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