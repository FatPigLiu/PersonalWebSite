using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Program1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            int now = DateTime.Now.TimeOfDay.Hours;
            if (now > 6 && now < 12)
            {

            }
            else if(now >= 12 && now < 18)
            {
                
            }
            ViewBag.HelloWorld = "";
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection formCollection)
        {
            string email = formCollection["inputEmail"];
            string password = formCollection["password"];

            return View();
        }
    }
}