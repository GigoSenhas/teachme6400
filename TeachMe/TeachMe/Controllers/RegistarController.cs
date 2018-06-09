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
        public ActionResult Register([Bind(Include="nome,data_nascimento,Password,Email,Telemovel,NIF,Cidade,Distrito,Freguesia,Porta,Coordenadas")] Cliente user)
        {

            if (ModelState.IsValid)
            {
                using (TeachMeDb db = new TeachMeDb())
                {
                    user.Password= TeachMe.MyHelpers.HashPassword(user.Password);
                    db.Cliente.Add(user);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Index", "Login"); 
        }
    }
}