using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DariaApi.Areas.Page.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            if (this.Request.HttpMethod == "POST")
            {
                var userName = this.Request.Form["username"];
                var entityId = this.Request.Form["entityid"];

                if (!string.IsNullOrEmpty(entityId))
                {
                }
            }

            return View();
        }
    }
}