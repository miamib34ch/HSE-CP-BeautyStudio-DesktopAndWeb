using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeautyStudioPractice.Controllers
{
    public class ДеньРожденияController : Controller
    {
        private BeautyStudioEntities db = new BeautyStudioEntities();
        // GET: ДеньРождения
        public ActionResult Index()
        {
            ViewBag.Именинники = db.Клиент.ToList().Where(s => s.Дата_рождения != null).ToList().Where(s => s.Дата_рождения.Value.Day == DateTime.Now.Day && s.Дата_рождения.Value.Month == DateTime.Now.Month).ToList();
            return View();
        }
    }
}