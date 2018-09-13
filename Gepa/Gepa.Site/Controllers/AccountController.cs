using Gepa.Site.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gepa.Site.Controllers
{
    public class AccountController : GepaBaseController
    {
        public ActionResult Login()
        {
            return View("_Login");
        }

        public ActionResult Register()
        {
            return View("_Register");
        }

        public ActionResult RecoverPassword()
        {
            return View("_RecoverPassword");
        }
    }
}