using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeachMe.Controllers
{
    public class CatalogoController : Controller
    {
        // GET: Catalogo
        public ActionResult PageCatalogo()
        {
            return View();
        }
    }
}