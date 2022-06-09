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
    public class Тип_процедурыController : Controller
    {
        private BeautyStudioEntities db = new BeautyStudioEntities();

        // GET: Тип_процедуры
        public ActionResult Index()
        {
            return View(db.Тип_процедуры.ToList());
        }

        // GET: Тип_процедуры/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Тип_процедуры/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_типа_процедуры,Название_типа_процедуры")] Тип_процедуры тип_процедуры)
        {
            if (db.Тип_процедуры.Count() != 0)
                тип_процедуры.Id_типа_процедуры = db.Тип_процедуры.ToList().Last().Id_типа_процедуры + 1;
            else
                тип_процедуры.Id_типа_процедуры = 0;
            if (ModelState.IsValid)
            {
                db.Тип_процедуры.Add(тип_процедуры);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(тип_процедуры);
        }

        // GET: Тип_процедуры/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Тип_процедуры тип_процедуры = db.Тип_процедуры.Find(id);
            if (тип_процедуры == null)
            {
                return HttpNotFound();
            }
            return View(тип_процедуры);
        }

        // POST: Тип_процедуры/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Тип_процедуры тип_процедуры = db.Тип_процедуры.Find(id);
            db.Тип_процедуры.Remove(тип_процедуры);
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
