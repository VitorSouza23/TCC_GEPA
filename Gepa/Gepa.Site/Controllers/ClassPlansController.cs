using Gepa.Site.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gepa.Site.Controllers
{
    [Authorize]
    public class ClassPlansController : GepaBaseController
    {
        // GET: ClassPlans
        public ActionResult Index()
        {
            return View("ClassPlanDetails");
        }
    }
}