using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeachMe.Controllers
{
    public class EquipaController : Controller
    {
        // GET: Equipa
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PageEquipa()
        {
            return RedirectToAction("Index", "Equipa");
        }
    }
}