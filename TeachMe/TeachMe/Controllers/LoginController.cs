using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeachMe.Models;

namespace TeachMe.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Autherize(TeachMe.Models.Cliente clienteModel)
        {
            using (TeachMeDb db = new TeachMeDb())
            {
                var clientDetails = db.Cliente.Where(x => x.Email == clienteModel.Email && x.Password == clienteModel.Password).FirstOrDefault();
                if (clientDetails == null)
                {
                    // clienteModel.LoginMessageError = "Mail ou password incorretos";
                    return View("Index", clienteModel);

                }
                else
                {
                    Session["clientID"] = clientDetails.ID;
                    Session["clientName"] = clientDetails.Nome;
                    return RedirectToAction("Index", "Home");
                }
            }
        }

        public ActionResult LogOut()
        {
            int clientId = (int)Session["clientID"];
            Session.Abandon();
            return RedirectToAction("Index", "Login");

        }
    }
}