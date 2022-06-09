using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Text;
using BeautyStudioPractice;
using Microsoft.AspNetCore.Http;
using System.Xml.Linq;

namespace BeautyStudioPractice.Controllers
{
    public class Тип_иглыController : Controller
    {
        private BeautyStudioEntities db = new BeautyStudioEntities();

        // GET: Тип_иглы
        public ActionResult Index()
        {
            return View(db.Тип_иглы.ToList());
        }

        // GET: Тип_иглы/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Тип_иглы/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_типа_иглы,Название_типа_иглы")] Тип_иглы тип_иглы)
        {
            if (db.Тип_иглы.Count() != 0)
                тип_иглы.Id_типа_иглы = db.Тип_иглы.ToList().Last().Id_типа_иглы + 1;
            else
                тип_иглы.Id_типа_иглы = 0;
            if (ModelState.IsValid)
            {
                db.Тип_иглы.Add(тип_иглы);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(тип_иглы);
        }

        // GET: Тип_иглы/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Тип_иглы тип_иглы = db.Тип_иглы.Find(id);
            if (тип_иглы == null)
            {
                return HttpNotFound();
            }
            return View(тип_иглы);
        }

        // POST: Тип_иглы/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Тип_иглы тип_иглы = db.Тип_иглы.Find(id);
            db.Тип_иглы.Remove(тип_иглы);
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

        [HttpPost]
        public ActionResult Export()
        {
            DataTable dt = new DataTable("Тип иглы");
            dt.Columns.Add("Id типа иглы", typeof(int));
            dt.Columns.Add("Название типа иглы", typeof(string));

            for (int i = 0; i < db.Тип_иглы.Count(); i++)
                dt.Rows.Add(new object[] { int.Parse(db.Тип_иглы.ToList()[i].Id_типа_иглы.ToString()), (string)db.Тип_иглы.ToList()[i].Название_типа_иглы.ToString() });

            using (var stream = new MemoryStream())
            {
                dt.WriteXml(stream);
                stream.Flush();

                return new FileContentResult(stream.ToArray(), "application/xhtml+xml")
                {
                    FileDownloadName = "export.xml"
                };
            }
        }

        [HttpPost]
        public ActionResult Import(HttpPostedFileBase Data)
        {
            try
            {
                if (Data == null)
                    return View("Error");
                DataTable dt = new DataTable("Тип иглы");
                dt.Columns.Add("Id типа иглы", typeof(int));
                dt.Columns.Add("Название типа иглы", typeof(string));
                dt.ReadXml(Data.InputStream);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Тип_иглы ti = new Тип_иглы();
                    ti.Id_типа_иглы = db.Тип_иглы.ToList().Last().Id_типа_иглы+1;
                    ti.Название_типа_иглы = (string)dt.Rows[i].ItemArray[1];
                    db.Тип_иглы.Add(ti);
                }
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }
        }
    }
}
