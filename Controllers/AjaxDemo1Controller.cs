using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnTap_Ajax.Controllers
{
    public class AjaxDemo1Controller : Controller
    {
        // GET: AjaxDemo1
        public ActionResult Index()
        {
            return View();
        }

        // Cong 2 so 
        public ActionResult Math(int a, int b)
        {
            var x = a+ b;
            var result = a + " + " + b + " = " + x;
            var data = new { status = "ok", result };
             return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}