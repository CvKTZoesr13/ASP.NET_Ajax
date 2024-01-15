using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnTap_Ajax.Controllers
{
    public class AjaxDemo2Controller : Controller
    {
        // GET: AjaxDemo2
        public ActionResult Index()
        {
            return View();
        }
        // simple login
        public string Login(string username, string password) {
            string result = "";
            if (username == "admin" && password == "123")
            {
                result = "Login successfully, welcome traveler <3";
            }
            else result = "Invalid username or/and password!";

            return result;
        }
    }
}