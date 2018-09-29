using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PramodQR.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }
        public ActionResult Forget()
        {
            return View();
        }
        public ActionResult TermCondition()
        {
            return View();
        }

    }
}
