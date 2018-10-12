using AutoMapper;
using Gepa.Entities.Framework.Entities.ClassPlans;
using Gepa.Site.Helpers;
using Gepa.Site.Models.ClassPlans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Gepa.Site.Controllers
{
    [Authorize]
    public class DashboardController : GepaBaseController
    {
        // GET: Dashboard
        public async Task<ActionResult> Index()
        {
            var currentTeacher = await Helper.GetCurrentTeacherAsync();
            var classPlans = await ClassPlanService.FindAllTeacherClassPlans(currentTeacher.TeacherId, true);
            var model = Mapper.Map<List<ClassPlanModel>>(classPlans);
            var user = Helper.GetCurrentUser();
            if (string.IsNullOrWhiteSpace(currentTeacher.Name))
                ViewBag.UserName = user.UserName;
            else
                ViewBag.UserName = currentTeacher.Name;
            return View(model);
        }
    }
}