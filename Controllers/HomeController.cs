using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using FormValidation.Models;

namespace FormValidation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormValidation.Models.Login login)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return View(login);
        }
    }
}