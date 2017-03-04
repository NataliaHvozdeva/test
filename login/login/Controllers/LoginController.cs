using login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

            return View();
        }
    }
}