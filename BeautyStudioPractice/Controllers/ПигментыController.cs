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
    public class ПигментыController : Controller
    {
        private BeautyStudioEntities db = new BeautyStudioEntities();

        // GET: Пигменты
        public ActionResult Index()
        {
            return View(db.Пигменты.ToList());
        }

        // GET: Пигменты/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Пигменты/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_пигмента,Название_пигмента")] Пигменты пигменты)
        {
            if (db.Пигменты.Count() != 0)
                пигменты.Id_пигмента = db.Пигменты.ToList().Last().Id_пигмента + 1;
            else
                пигменты.Id_пигмента = 0;
            if (ModelState.IsValid)
            {
                db.Пигменты.Add(пигменты);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(пигменты);
        }

        // GET: Пигменты/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Пигменты пигменты = db.Пигменты.Find(id);
            if (пигменты == null)
            {
                return HttpNotFound();
            }
            return View(пигменты);
        }

        // POST: Пигменты/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Пигменты пигменты = db.Пигменты.Find(id);
            db.Пигменты.Remove(пигменты);
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
