using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DariaApi.Pages.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string entityId)
        {
            if (this.Response.StatusCode == 200)
            {
                return this.RedirectToAction("Index", "App");
            }

            return this.View();
        }
    }
}