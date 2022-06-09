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
    public class ПосещениеController : Controller
    {
        private BeautyStudioEntities db = new BeautyStudioEntities();

        // GET: Посещение
        public ActionResult Index()
        {
            var посещение = db.Посещение.Include(п => п.Клиент).Include(п => п.Скидка).Include(п => п.Тип_иглы);
            return View(посещение.ToList());
        }

        // GET: Посещение/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Посещение посещение = db.Посещение.Find(id);
            if (посещение == null)
            {
                return HttpNotFound();
            }
            return View(посещение);
        }

        // GET: Посещение/Create
        public ActionResult Create(int id)
        {
            ViewBag.Id_клиента = new SelectList(db.Клиент.Where(w => w.Id_клиента == id), "Id_клиента", "Фамилия");
            ViewBag.Id_скидки = new SelectList(db.Скидка, "Id_скидки", "Размер_скидки");
            ViewBag.Id_типа_иглы = new SelectList(db.Тип_иглы, "Id_типа_иглы", "Название_типа_иглы");
            return View();
        }

        // POST: Посещение/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_посещения,Id_клиента,Дата_и_время_посещения,Итоговая_цена,Id_типа_иглы,Примечание_о_посещении,Id_скидки")] Посещение посещение)
        {
            if (db.Посещение.Count() != 0)
                посещение.Id_посещения = db.Посещение.ToList().Last().Id_посещения + 1;
            else
                посещение.Id_посещения = 0;
            посещение.Итоговая_цена -= db.Скидка.Find(посещение.Id_скидки).Размер_скидки;
            if (ModelState.IsValid)
            {
                db.Посещение.Add(посещение);
                db.SaveChanges();
                Session["Посещение"] = посещение;
                return RedirectToAction("Продолжить");
            }

            ViewBag.Id_клиента = new SelectList(db.Клиент, "Id_клиента", "Фамилия", посещение.Id_клиента);
            ViewBag.Id_скидки = new SelectList(db.Скидка, "Id_скидки", "Id_скидки", посещение.Id_скидки);
            ViewBag.Id_типа_иглы = new SelectList(db.Тип_иглы, "Id_типа_иглы", "Название_типа_иглы", посещение.Id_типа_иглы);
            return View(посещение);
        }

        // GET: Посещение/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Посещение посещение = db.Посещение.Find(id);
            if (посещение == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_клиента = new SelectList(db.Клиент, "Id_клиента", "Фамилия", посещение.Id_клиента);
            ViewBag.Id_скидки = new SelectList(db.Скидка, "Id_скидки", "Id_скидки", посещение.Id_скидки);
            ViewBag.Id_типа_иглы = new SelectList(db.Тип_иглы, "Id_типа_иглы", "Название_типа_иглы", посещение.Id_типа_иглы);
            return View(посещение);
        }

        // POST: Посещение/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_посещения,Id_клиента,Дата_и_время_посещения,Итоговая_цена,Id_типа_иглы,Примечание_о_посещении,Id_скидки")] Посещение посещение)
        {
            if (ModelState.IsValid)
            {
                db.Entry(посещение).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id_клиента = new SelectList(db.Клиент, "Id_клиента", "Фамилия", посещение.Id_клиента);
            ViewBag.Id_скидки = new SelectList(db.Скидка, "Id_скидки", "Id_скидки", посещение.Id_скидки);
            ViewBag.Id_типа_иглы = new SelectList(db.Тип_иглы, "Id_типа_иглы", "Название_типа_иглы", посещение.Id_типа_иглы);
            return View(посещение);
        }

        // GET: Посещение/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Посещение посещение = db.Посещение.Find(id);
            if (посещение == null)
            {
                return HttpNotFound();
            }
            return View(посещение);
        }

        // POST: Посещение/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Посещение посещение = db.Посещение.Find(id);
            db.Посещение.Remove(посещение);
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
            return RedirectToAction("Create", new { @Controller = "Процедуры_клиента" });
        }


        public ActionResult FindVisit(DateTime? dt)
        {
            var query = db.Посещение.Where(s => s.Дата_и_время_посещения.Year == dt.Value.Year && s.Дата_и_время_посещения.Month == dt.Value.Month && s.Дата_и_время_посещения.Day == dt.Value.Day);
            Посещение[] посещения = new Посещение[query.Count()];
            int i = 0;
            foreach (Посещение посещение in query)
            {
                посещения[i] = посещение;
                i++;
            }
            ViewBag.НайденныеПосещения = посещения;
            return View();
        }
    }
}
