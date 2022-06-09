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
    public class ПроцедураController : Controller
    {
        private BeautyStudioEntities db = new BeautyStudioEntities();

        // GET: Процедура
        public ActionResult Index()
        {
            var процедура = db.Процедура.Include(п => п.Тип_процедуры);
            return View(процедура.ToList());
        }

        // GET: Процедура/Create
        public ActionResult Create()
        {
            ViewBag.Id_типа_процедуры = new SelectList(db.Тип_процедуры, "Id_типа_процедуры", "Название_типа_процедуры");
            return View();
        }

        // POST: Процедура/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_процедуры,Название_процедуры,Id_типа_процедуры,Цена_процедуры")] Процедура процедура)
        {
            if (db.Процедура.Count() != 0)
                процедура.Id_процедуры = db.Процедура.ToList().Last().Id_процедуры + 1;
            else
                процедура.Id_процедуры = 0;
            if (ModelState.IsValid)
            {
                db.Процедура.Add(процедура);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id_типа_процедуры = new SelectList(db.Тип_процедуры, "Id_типа_процедуры", "Название_типа_процедуры", процедура.Id_типа_процедуры);
            return View(процедура);
        }

        // GET: Процедура/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Процедура процедура = db.Процедура.Find(id);
            if (процедура == null)
            {
                return HttpNotFound();
            }
            return View(процедура);
        }

        // POST: Процедура/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Процедура процедура = db.Процедура.Find(id);
            db.Процедура.Remove(процедура);
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
