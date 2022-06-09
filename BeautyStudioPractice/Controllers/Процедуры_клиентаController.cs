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
    public class Процедуры_клиентаController : Controller
    {
        private BeautyStudioEntities db = new BeautyStudioEntities();

        // GET: Процедуры_клиента
        public ActionResult Index()
        {
            var процедуры_клиента = db.Процедуры_клиента.Include(п => п.Пигменты).Include(п => п.Процедура);
            return View(процедуры_клиента.ToList());
        }

        // GET: Процедуры_клиента/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Процедуры_клиента процедуры_клиента = db.Процедуры_клиента.Find(id);
            if (процедуры_клиента == null)
            {
                return HttpNotFound();
            }
            return View(процедуры_клиента);
        }

        // GET: Процедуры_клиента/Create
        public ActionResult Create()
        {
            ViewBag.Id_пигмента = new SelectList(db.Пигменты, "Id_пигмента", "Название_пигмента");
            ViewBag.Id_процедуры = new SelectList(db.Процедура, "Id_процедуры", "Название_процедуры");
            return View();
        }

        // POST: Процедуры_клиента/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_процедуры_клиента,Id_процедуры,Id_пигмента,Примечание_о_процедуре_клиента")] Процедуры_клиента процедуры_клиента)
        {
            if (db.Процедуры_клиента.Count() != 0)
                процедуры_клиента.Id_процедуры_клиента = db.Процедуры_клиента.ToList().Last().Id_процедуры_клиента + 1;
            else
                процедуры_клиента.Id_процедуры_клиента = 0;
            if (ModelState.IsValid)
            {
                db.Процедуры_клиента.Add(процедуры_клиента);
                db.SaveChanges();
                Посещение посещение = (Посещение)Session["Посещение"];
                db.Посещение.Find(посещение.Id_посещения).Процедуры_клиента.Add(процедуры_клиента);
                db.Посещение.Find(посещение.Id_посещения).Итоговая_цена += db.Процедура.Find(процедуры_клиента.Id_процедуры).Цена_процедуры;
                db.SaveChanges();
                return RedirectToAction("Продолжить");
            }

            ViewBag.Id_пигмента = new SelectList(db.Пигменты, "Id_пигмента", "Название_пигмента", процедуры_клиента.Id_пигмента);
            ViewBag.Id_процедуры = new SelectList(db.Процедура, "Id_процедуры", "Название_процедуры", процедуры_клиента.Id_процедуры);
            return View(процедуры_клиента);
        }

        // GET: Процедуры_клиента/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Процедуры_клиента процедуры_клиента = db.Процедуры_клиента.Find(id);
            if (процедуры_клиента == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_пигмента = new SelectList(db.Пигменты, "Id_пигмента", "Название_пигмента", процедуры_клиента.Id_пигмента);
            ViewBag.Id_процедуры = new SelectList(db.Процедура, "Id_процедуры", "Название_процедуры", процедуры_клиента.Id_процедуры);
            return View(процедуры_клиента);
        }

        // POST: Процедуры_клиента/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_процедуры_клиента,Id_процедуры,Id_пигмента,Примечание_о_процедуре_клиента")] Процедуры_клиента процедуры_клиента)
        {
            if (ModelState.IsValid)
            {
                db.Entry(процедуры_клиента).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id_пигмента = new SelectList(db.Пигменты, "Id_пигмента", "Название_пигмента", процедуры_клиента.Id_пигмента);
            ViewBag.Id_процедуры = new SelectList(db.Процедура, "Id_процедуры", "Название_процедуры", процедуры_клиента.Id_процедуры);
            return View(процедуры_клиента);
        }

        // GET: Процедуры_клиента/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Процедуры_клиента процедуры_клиента = db.Процедуры_клиента.Find(id);
            if (процедуры_клиента == null)
            {
                return HttpNotFound();
            }
            return View(процедуры_клиента);
        }

        // POST: Процедуры_клиента/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Процедуры_клиента процедуры_клиента = db.Процедуры_клиента.Find(id);
            db.Процедуры_клиента.Remove(процедуры_клиента);
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
        public ActionResult Продолжить()
        {
            return View();
        }
    }
}
