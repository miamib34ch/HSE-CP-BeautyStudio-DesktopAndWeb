using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BeautyStudioPractice;

namespace BeautyStudioPractice.Controllers
{
    public class Тип_кожиController : Controller
    {
        private BeautyStudioEntities db = new BeautyStudioEntities();

        // GET: Тип_кожи
        public ActionResult Index()
        {
            return View(db.Тип_кожи.ToList());
        }

        // GET: Тип_кожи/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Тип_кожи/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_типа_кожи,Название_типа_кожи")] Тип_кожи тип_кожи)
        {
            if (db.Тип_кожи.Count() != 0)
                тип_кожи.Id_типа_кожи = db.Тип_кожи.ToList().Last().Id_типа_кожи + 1;
            else
                тип_кожи.Id_типа_кожи = 0;
            if (ModelState.IsValid)
            {
                db.Тип_кожи.Add(тип_кожи);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(тип_кожи);
        }
                
        // GET: Тип_кожи/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Тип_кожи тип_кожи = db.Тип_кожи.Find(id);
            if (тип_кожи == null)
            {
                return HttpNotFound();
            }
            return View(тип_кожи);
        }

        // POST: Тип_кожи/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Тип_кожи тип_кожи = db.Тип_кожи.Find(id);
            db.Тип_кожи.Remove(тип_кожи);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
