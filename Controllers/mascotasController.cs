using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aplicacionOptativa2.Models;

namespace aplicacionOptativa2.Controllers
{
    public class mascotasController : Controller
    {
        private aplicacionOptativa2Context db = new aplicacionOptativa2Context();

        //
        // GET: /mascotas/

        public ActionResult Index()
        {
            return View(db.mascotas.ToList());
        }

        //
        // GET: /mascotas/Details/5

        public ActionResult Details(int id = 0)
        {
            mascota mascota = db.mascotas.Find(id);
            if (mascota == null)
            {
                return HttpNotFound();
            }
            return View(mascota);
        }

        //
        // GET: /mascotas/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /mascotas/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(mascota mascota)
        {
            if (ModelState.IsValid)
            {
                db.mascotas.Add(mascota);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mascota);
        }

        //
        // GET: /mascotas/Edit/5

        public ActionResult Edit(int id = 0)
        {
            mascota mascota = db.mascotas.Find(id);
            if (mascota == null)
            {
                return HttpNotFound();
            }
            return View(mascota);
        }

        //
        // POST: /mascotas/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(mascota mascota)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mascota).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mascota);
        }

        //
        // GET: /mascotas/Delete/5

        public ActionResult Delete(int id = 0)
        {
            mascota mascota = db.mascotas.Find(id);
            if (mascota == null)
            {
                return HttpNotFound();
            }
            return View(mascota);
        }

        //
        // POST: /mascotas/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            mascota mascota = db.mascotas.Find(id);
            db.mascotas.Remove(mascota);
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