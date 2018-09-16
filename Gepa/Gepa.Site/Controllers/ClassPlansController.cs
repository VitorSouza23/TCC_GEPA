using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gepa.Site.Controllers
{
    public class ClassPlansController : Controller
    {
        // GET: ClassPlans
        public ActionResult Index()
        {
            return View("ClassPlanDetails");
        }
    }
}