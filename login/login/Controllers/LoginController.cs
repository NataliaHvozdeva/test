using login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

//Обработчик
//Обработчик

namespace login.Controllers
{
    public class LoginController : Controller
    {
        [Route]
        public ActionResult Login()
        {
            return View();
        }

        [Route] [HttpPost]
        public ActionResult Login(AuthorizationModel model)
        {
            if (model.login == "user")
                { 
            FormsAuthentication.SetAuthCookie(model.login, true); // cookie
            return RedirectToAction("Securepage", "Secure");
                }

            return View();
        }
    }
}