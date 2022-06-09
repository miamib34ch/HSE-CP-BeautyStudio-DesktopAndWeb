using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BeautyStudioPractice;
using Word = Microsoft.Office.Interop.Word;

namespace BeautyStudioPractice.Controllers
{
    public class КлиентController : Controller
    {
        private BeautyStudioEntities db = new BeautyStudioEntities();

        // GET: Клиент
        public ActionResult Index()
        {
            var клиент = db.Клиент.Include(к => к.Тип_кожи);
            return View(клиент.ToList());
        }

        // GET: Клиент/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Клиент клиент = db.Клиент.Find(id);
            if (клиент == null)
            {
                return HttpNotFound();
            }
            ViewBag.ЕгоПосещения = db.Посещение.Where(s => s.Id_клиента == клиент.Id_клиента).ToList();
            return View(клиент);
        }

        // GET: Клиент/Create
        public ActionResult Create()
        {
            ViewBag.Id_типа_кожи = new SelectList(db.Тип_кожи, "Id_типа_кожи", "Название_типа_кожи");
            return View();
        }

        // POST: Клиент/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_клиента,Фамилия,Имя,Отчество,Номер_телефона,Дата_рождения,Id_типа_кожи,Противопоказания,Примечание_о_клиенте,Соглашение,Как_узнал_о_салоне")] Клиент клиент)
        {
            if (db.Клиент.Count() != 0)
                клиент.Id_клиента = db.Клиент.ToList().Last().Id_клиента + 1;
            else
                клиент.Id_клиента = 0;
            if (ModelState.IsValid)
            {
                db.Клиент.Add(клиент);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id_типа_кожи = new SelectList(db.Тип_кожи, "Id_типа_кожи", "Название_типа_кожи", клиент.Id_типа_кожи);
            return View(клиент);
        }

        // GET: Клиент/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Клиент клиент = db.Клиент.Find(id);
            if (клиент == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_типа_кожи = new SelectList(db.Тип_кожи, "Id_типа_кожи", "Название_типа_кожи", клиент.Id_типа_кожи);
            return View(клиент);
        }

        // POST: Клиент/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_клиента,Фамилия,Имя,Отчество,Номер_телефона,Дата_рождения,Id_типа_кожи,Противопоказания,Примечание_о_клиенте,Соглашение,Как_узнал_о_салоне")] Клиент клиент)
        {
            if (ModelState.IsValid)
            {
                db.Entry(клиент).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id_типа_кожи = new SelectList(db.Тип_кожи, "Id_типа_кожи", "Название_типа_кожи", клиент.Id_типа_кожи);
            return View(клиент);
        }

        // GET: Клиент/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Клиент клиент = db.Клиент.Find(id);
            if (клиент == null)
            {
                return HttpNotFound();
            }
            return View(клиент);
        }

        // POST: Клиент/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Клиент клиент = db.Клиент.Find(id);
            db.Клиент.Remove(клиент);
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

        public ActionResult FindClient(string phone)
        {
            var query = db.Клиент.Where(s => s.Номер_телефона == phone);
            Клиент[] клиенты = new Клиент[query.Count()];
            int i = 0;
            foreach (Клиент клиент in query)
            {
                клиенты[i] = клиент;
                i++;
            }
            ViewBag.Найденные = клиенты;
            return View();
        }

        public ActionResult Visit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Клиент клиент = db.Клиент.Find(id);
            if (клиент == null)
            {
                return HttpNotFound();
            }
            return RedirectToAction("Create", "Посещение", new { @type = "get", @id = клиент.Id_клиента });
        }

        public ActionResult WordOpen(int idVisit)
        {
            try
            {
                //запускаем Word и открываем шаблон файла   
                object fileName = Server.MapPath("/Шаблон.docx");
            Word.Application WordApplication = new Word.Application();
            WordApplication.Visible = true; //выводим документ на экран
            Word.Document WordDocument = WordApplication.Documents.Open(fileName);
            //присваиваем значение полю
            int idклиент = db.Посещение.Where(s => s.Id_посещения == idVisit).First().Id_клиента;
            Клиент клиент = db.Клиент.Where(s => s.Id_клиента == idклиент).First();
            WordDocument.Variables["SURNAME"].Value = клиент.Фамилия + " " + клиент.Имя + " " + клиент.Отчество;
            if (клиент.Номер_телефона == "")
                WordDocument.Variables["NUMBER"].Value = " ";
            else
                WordDocument.Variables["NUMBER"].Value = клиент.Номер_телефона;
            if (клиент.Дата_рождения.ToString() == "")
                WordDocument.Variables["DATA"].Value = " ";
            else
                WordDocument.Variables["DATA"].Value = клиент.Дата_рождения.Value.Day.ToString() + "." + клиент.Дата_рождения.Value.Month.ToString() + "." + клиент.Дата_рождения.Value.Year.ToString();
            var посещение = db.Посещение.Where(s => s.Id_посещения == idVisit).First();
            if (посещение == null)
            {
                WordDocument.Variables["VISITING"].Value = "Посещений нет!";
                WordDocument.Variables["PRICE"].Value = " ";
                WordDocument.Variables["PRICENUM"].Value = " ";
                WordDocument.Variables["SALE"].Value = " ";
                WordDocument.Variables["SALENUM"].Value = " ";
                WordDocument.Variables["PROCEDURE"].Value = " ";
                WordDocument.Variables["ALLPRO"].Value = " ";
            }
            else
            {
                WordDocument.Variables["VISITING"].Value = "Посещение " + посещение.Дата_и_время_посещения.ToString();
                WordDocument.Variables["PRICE"].Value = "Цена:";
                WordDocument.Variables["PRICENUM"].Value = посещение.Итоговая_цена.ToString();
                WordDocument.Variables["SALE"].Value = "Применена скидка:";
                WordDocument.Variables["SALENUM"].Value = посещение.Скидка.Размер_скидки.ToString();
                WordDocument.Variables["PROCEDURE"].Value = "Процедуры:";
                string s = "";
                foreach (var процедура in посещение.Процедуры_клиента)
                    s += процедура.Процедура.Название_процедуры + " " + процедура.Пигменты.Название_пигмента.ToString().ToLower() + "; ";
                if (s != "")
                    WordDocument.Variables["ALLPRO"].Value = s;
                else
                    WordDocument.Variables["ALLPRO"].Value = " ";

            }
            //обновляем поля документа
            WordDocument.Fields.Update();
            return Redirect($"Details/{клиент.Id_клиента}");
            }
            catch
            {
                int idклиент = db.Посещение.Where(s => s.Id_посещения == idVisit).First().Id_клиента;
                Клиент клиент = db.Клиент.Where(s => s.Id_клиента == idклиент).First();
                return Redirect($"Details/{клиент.Id_клиента}");
            }
        }
    }
}
