using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeachMe.Models;

namespace TeachMe.Controllers
{
    public class RegistarController : Controller
    {
        // GET: Registar
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PageRegisto()
        {

            return RedirectToAction("Index", "Registar");

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Cliente user)
        {

            if (ModelState.IsValid)
            {

                using (TeachMeDb db = new TeachMeDb())
                {
                    db.Cliente.Add(user);
                    db.SaveChanges();
                    ModelState.Clear();
                    ViewBag.Message = user.Nome + " " + "registado com sucesso";
                    user = null;

                }
            }
            return RedirectToAction("Index", "Login"); ;
        }
    }
}