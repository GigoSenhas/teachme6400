using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeachMe.Controllers
{
    public class EntrarController : Controller
    {
        // GET: Entrar
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PageEntrar()
        {
            return RedirectToAction("Index", "Login");
        }
    }
}