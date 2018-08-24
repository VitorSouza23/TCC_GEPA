using Gepa.Business.Accounts;
using Gepa.Business.Calendar;
using Gepa.Business.ClassPlans;
using Gepa.Business.SchoolClasses;
using Gepa.Business.Users;
using GepaManagement;
using GepaManagement.ServicesTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gepa.Site.Helpers
{
    public abstract class GepaBaseController : Controller
    {
        private IAccountService _accountService;
        private IAbstractSchoolEventService _abstractSchoolEventService;
        private ISchoolCalendarService _schoolCalendarService;
        private IChoresService _choresService;
        private IClassGoalsService _classGoalsService;
        private IClassPlanService _classPlanService;
        private IEvaluationService _evaluationService;
        private ILessonsContentService _lessonsContentService;
        private IClassDiaryService _classDiaryService;
        private IClassFrequencyService _classFrequency;
        private ISchoolClassService _schoolClassService;
        private ISchoolService _schoolService;
        private IStudentNoteService _studentNoteService;
        private IStudentPresenceService _studentPresenceService;
        private IStudentService _studentService;
        private ITeacherService _teacherService;

        protected IAccountService AccountService => _accountService = _accountService ?? (IAccountService)GepaManager.Instance.GetService(GepaServicesTypes.AccountService);

        protected IAbstractSchoolEventService AbstractSchoolEventService => _abstractSchoolEventService = _abstractSchoolEventService ?? (IAbstractSchoolEventService)GepaManager.Instance.GetService(GepaServicesTypes.AbstractShoolEventService);

        protected ISchoolCalendarService SchoolCalendarService => _schoolCalendarService = _schoolCalendarService ?? (ISchoolCalendarService)GepaManager.Instance.GetService(GepaServicesTypes.SchoolCalendarService);

        protected IChoresService ChoresService => _choresService = _choresService ?? (IChoresService)GepaManager.Instance.GetService(GepaServicesTypes.ChoresService);

        protected IClassGoalsService ClassGoalsService => _classGoalsService = _classGoalsService ?? (IClassGoalsService)GepaManager.Instance.GetService(GepaServicesTypes.ClassGoalsService);

        protected IClassPlanService ClassPlanService => _classPlanService = _classPlanService ?? (IClassPlanService)GepaManager.Instance.GetService(GepaServicesTypes.ClassPlanService);

        protected IEvaluationService EvaluationService => _evaluationService = _evaluationService ?? (IEvaluationService)GepaManager.Instance.GetService(GepaServicesTypes.EvaluationService);

        protected ILessonsContentService LessonsContentService => _lessonsContentService = _lessonsContentService ?? (ILessonsContentService)GepaManager.Instance.GetService(GepaServicesTypes.LessonsContentService);

        protected IClassDiaryService ClassDiaryService => _classDiaryService = _classDiaryService ?? (IClassDiaryService)GepaManager.Instance.GetService(GepaServicesTypes.ClassDiaryService);

        protected IClassFrequencyService ClassFrequency => _classFrequency = _classFrequency ?? (IClassFrequencyService)GepaManager.Instance.GetService(GepaServicesTypes.ClassFrequencyService);

        protected ISchoolClassService SchoolClassService => _schoolClassService = _schoolClassService ?? (ISchoolClassService)GepaManager.Instance.GetService(GepaServicesTypes.SchoolClassService);

        protected ISchoolService SchoolService => _schoolService = _schoolService ?? (ISchoolService)GepaManager.Instance.GetService(GepaServicesTypes.SchoolService);

        protected IStudentNoteService StudentNoteService => _studentNoteService = _studentNoteService ?? (IStudentNoteService)GepaManager.Instance.GetService(GepaServicesTypes.StudentNoteService);

        protected IStudentPresenceService StudentPresenceService => _studentPresenceService = _studentPresenceService ?? (IStudentPresenceService)GepaManager.Instance.GetService(GepaServicesTypes.StudentPresenceService);

        protected IStudentService StudentService => _studentService = _studentService ?? (IStudentService)GepaManager.Instance.GetService(GepaServicesTypes.StudentService);

        protected ITeacherService TeacherService => _teacherService = _teacherService ?? (ITeacherService)GepaManager.Instance.GetService(GepaServicesTypes.TeacherService);
    }
}