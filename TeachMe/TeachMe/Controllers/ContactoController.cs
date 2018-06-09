using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeachMe.Controllers
{
    public class ContactoController : Controller
    {
        // GET: Contacto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PageContacto()
        {
            return RedirectToAction("Index", "Contacto");
        }
    }
}