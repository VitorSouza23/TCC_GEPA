using AutoMapper;
using Gepa.Entities.Framework.Entities.ClassPlans;
using Gepa.Site.Helpers;
using Gepa.Site.Models.ClassPlans;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Gepa.Site.Controllers
{
    [Authorize]
    public class ClassPlansController : GepaBaseController
    {
        // GET: ClassPlans
        public ActionResult Index()
        {
            return View("ClassPlanDetails", new ClassPlanModel { Id = -1 });//Indica que é um novo plano de aula
        }

        [HttpPost]
        public async Task<ActionResult> SaveClassPlan(ClassPlanModel classPlanModel)
        {
            if (classPlanModel.Id < 0)//Novo plano de aula
            {
                var newClassPlan = Mapper.Map<ClassPlanModel, ClassPlan>(classPlanModel);
                var currentTeacher = await Helper.GetCurrentTeacherAsync();
                newClassPlan.TeacherId = currentTeacher.TeacherId;
                await ClassPlanService.InsertClassPlanAsync(newClassPlan);
                return Json(Url.Action("Index", "Dashboard"));
            }
            else if(classPlanModel.Id > 0)
            {
                var classPlan = Mapper.Map<ClassPlanModel, ClassPlan>(classPlanModel);
                ClassPlanService.UpdateClassPlan(classPlan);
                return Json(Url.Action("Index", "Dashboard"));
            }

            return View("ClassPlanDetails", classPlanModel);
        }

        public ActionResult ClassGoalsModalView(ClassGoalsModel classGoalsModel)
        {
            return PartialView("_AddClassGoalsModal", classGoalsModel);
        }

        public ActionResult LessonContentModalView(LessonsContentModel lessonsContentModel)
        {
            return PartialView("_AddLessonContentModal", lessonsContentModel);
        }

        public ActionResult EvaluationModalView(EvaluationModel evaluationModel)
        {
            return PartialView("_AddEvaluationModal", evaluationModel);
        }
        
        public ActionResult ChoresModalView(ChoresModel choresModel)
        {
            return PartialView("_AddChoresModal", choresModel);
        }

        public async Task<ActionResult> EditClassPlan(long classPlanId)
        {
            var classPlan = await ClassPlanService.FindClassPlanAsync(classPlanId);
            var model = Mapper.Map<ClassPlan, ClassPlanModel>(classPlan);
            return View("ClassPlanDetails", model);
        }

        public ActionResult RemoveClassPlan(long classPlanId)
        {
            var classPlan = ClassPlanService.FindClassPlan(classPlanId);
            ClassPlanService .DeleteClassPlan(classPlan);

            var classPlans = ClassPlanService.FindAllClassPlans();
            var model = Mapper.Map<List<ClassPlanModel>>(classPlans);

            return RedirectToAction("Index", "Dashboard", model);
        }
    }
}