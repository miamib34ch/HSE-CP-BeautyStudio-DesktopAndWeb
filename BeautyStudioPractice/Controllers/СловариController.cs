using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Mvc;

namespace BeautyStudioPractice.Controllers
{
    public class СловариController : Controller
    {
        // GET: Словари
        public ActionResult Index(string currentpassword)
        {
            string pass = "";
            using (StreamReader sr = new StreamReader(Server.MapPath("/pass.txt")))
            {
                pass = sr.ReadToEnd();
            }
            if (currentpassword == pass)
                return View();
            else return View("Password");
        }

        public ActionResult Password()
        {
            return View();
        }

        public ActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ChangePassword(string newpass)
        {
            string str = string.Empty;
            using (System.IO.StreamReader reader = System.IO.File.OpenText(Server.MapPath("/pass.txt")))
            {
                str = reader.ReadToEnd();
            }
            str = str.Replace(str, newpass);

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(Server.MapPath("/pass.txt")))
            {
                file.Write(str);
            }
            return View("Password");
        }
    }
}