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
    public class СкидкаController : Controller
    {
        private BeautyStudioEntities db = new BeautyStudioEntities();

        // GET: Скидка
        public ActionResult Index()
        {
            return View(db.Скидка.ToList());
        }

        // GET: Скидка/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Скидка/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_скидки,Размер_скидки")] Скидка скидка)
        {
            if (db.Скидка.Count() != 0)
                скидка.Id_скидки = db.Скидка.ToList().Last().Id_скидки + 1;
            else
                скидка.Id_скидки = 0;
            if (ModelState.IsValid)
            {
                db.Скидка.Add(скидка);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(скидка);
        }

        // GET: Скидка/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Скидка скидка = db.Скидка.Find(id);
            if (скидка == null)
            {
                return HttpNotFound();
            }
            return View(скидка);
        }

        // POST: Скидка/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Скидка скидка = db.Скидка.Find(id);
            db.Скидка.Remove(скидка);
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
