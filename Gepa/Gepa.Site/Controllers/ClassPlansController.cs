using AutoMapper;
using Gepa.Entities.Framework.Entities.ClassPlans;
using Gepa.Site.Helpers;
using Gepa.Site.Models.ClassPlans;
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
    }
}