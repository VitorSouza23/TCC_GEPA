﻿using Gepa.Site.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gepa.Site.Controllers
{
    public class HomeController : GepaBaseController
    {
        public ActionResult Index()
        {
            return View();
        }        
    }
}