using AutoMapper;
using Gepa.Site.Helpers;
using Gepa.Site.Models.ClassPlans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gepa.Site.Controllers
{
    [Authorize]
    public class DashboardController : GepaBaseController
    {
        // GET: Dashboard
        public ActionResult Index()
        {

            var classPlans = ClassPlanService.FindAllClassPlans();
            var model = Mapper.Map<List<ClassPlanModel>>(classPlans);

            return View(model);
        }
    }
}