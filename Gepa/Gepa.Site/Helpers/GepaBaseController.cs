using Gepa.Business.Calendar;
using Gepa.Business.ClassPlans;
using Gepa.Business.SchoolClasses;
using Gepa.Business.Users;
using Gepa.Identity.Base.StartConfig;
using Gepa.Management.Services;
using Gepa.Management.Services.ServicesTypes;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.Web;
using System.Web.Mvc;

namespace Gepa.Site.Helpers
{
    public abstract class GepaBaseController : Controller
    {
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
        private ApplicationSignInManager _signInService;
        private ApplicationUserManager _userService;
        private ApplicationRoleManager _roleService;

        protected IAbstractSchoolEventService AbstractSchoolEventService => _abstractSchoolEventService = _abstractSchoolEventService ?? (IAbstractSchoolEventService)GepaServices.Instance.GetService(GepaServicesTypes.AbstractShoolEventService);

        protected ISchoolCalendarService SchoolCalendarService => _schoolCalendarService = _schoolCalendarService ?? (ISchoolCalendarService)GepaServices.Instance.GetService(GepaServicesTypes.SchoolCalendarService);

        protected IChoresService ChoresService => _choresService = _choresService ?? (IChoresService)GepaServices.Instance.GetService(GepaServicesTypes.ChoresService);

        protected IClassGoalsService ClassGoalsService => _classGoalsService = _classGoalsService ?? (IClassGoalsService)GepaServices.Instance.GetService(GepaServicesTypes.ClassGoalsService);

        protected IClassPlanService ClassPlanService => _classPlanService = _classPlanService ?? (IClassPlanService)GepaServices.Instance.GetService(GepaServicesTypes.ClassPlanService);

        protected IEvaluationService EvaluationService => _evaluationService = _evaluationService ?? (IEvaluationService)GepaServices.Instance.GetService(GepaServicesTypes.EvaluationService);

        protected ILessonsContentService LessonsContentService => _lessonsContentService = _lessonsContentService ?? (ILessonsContentService)GepaServices.Instance.GetService(GepaServicesTypes.LessonsContentService);

        protected IClassDiaryService ClassDiaryService => _classDiaryService = _classDiaryService ?? (IClassDiaryService)GepaServices.Instance.GetService(GepaServicesTypes.ClassDiaryService);

        protected IClassFrequencyService ClassFrequency => _classFrequency = _classFrequency ?? (IClassFrequencyService)GepaServices.Instance.GetService(GepaServicesTypes.ClassFrequencyService);

        protected ISchoolClassService SchoolClassService => _schoolClassService = _schoolClassService ?? (ISchoolClassService)GepaServices.Instance.GetService(GepaServicesTypes.SchoolClassService);

        protected ISchoolService SchoolService => _schoolService = _schoolService ?? (ISchoolService)GepaServices.Instance.GetService(GepaServicesTypes.SchoolService);

        protected IStudentNoteService StudentNoteService => _studentNoteService = _studentNoteService ?? (IStudentNoteService)GepaServices.Instance.GetService(GepaServicesTypes.StudentNoteService);

        protected IStudentPresenceService StudentPresenceService => _studentPresenceService = _studentPresenceService ?? (IStudentPresenceService)GepaServices.Instance.GetService(GepaServicesTypes.StudentPresenceService);

        protected IStudentService StudentService => _studentService = _studentService ?? (IStudentService)GepaServices.Instance.GetService(GepaServicesTypes.StudentService);

        protected ITeacherService TeacherService => _teacherService = _teacherService ?? (ITeacherService)GepaServices.Instance.GetService(GepaServicesTypes.TeacherService);

        protected ApplicationSignInManager SignInService
        {
            get
            {
                return _signInService ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInService = value;
            }
        }

        protected ApplicationUserManager UserService
        {
            get
            {
                return _userService ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userService = value;
            }
        }

        protected ApplicationRoleManager RoleService
        {
            get
            {
                return _roleService ?? HttpContext.GetOwinContext().Get<ApplicationRoleManager>();
            }
            private set
            {
                _roleService = value;
            }
        }

        #region Auxiliares
        // Usado para proteção XSRF ao adicionar logons externos
        protected const string XsrfKey = "XsrfId";

        protected IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        protected void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        protected ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }

        protected class ChallengeResult : HttpUnauthorizedResult
        {
            public ChallengeResult(string provider, string redirectUri)
                : this(provider, redirectUri, null)
            {
            }

            public ChallengeResult(string provider, string redirectUri, string userId)
            {
                LoginProvider = provider;
                RedirectUri = redirectUri;
                UserId = userId;
            }

            public string LoginProvider { get; set; }
            public string RedirectUri { get; set; }
            public string UserId { get; set; }

            public override void ExecuteResult(ControllerContext context)
            {
                var properties = new AuthenticationProperties { RedirectUri = RedirectUri };
                if (UserId != null)
                {
                    properties.Dictionary[XsrfKey] = UserId;
                }
                context.HttpContext.GetOwinContext().Authentication.Challenge(properties, LoginProvider);
            }
        }

        protected bool HasPassword()
        {
            var user = UserService.FindById(User.Identity.GetUserId());
            if (user != null)
            {
                return user.PasswordHash != null;
            }
            return false;
        }

        protected bool HasPhoneNumber()
        {
            var user = UserService.FindById(User.Identity.GetUserId());
            if (user != null)
            {
                return user.PhoneNumber != null;
            }
            return false;
        }

        public enum ManageMessageId
        {
            AddPhoneSuccess,
            ChangePasswordSuccess,
            SetTwoFactorSuccess,
            SetPasswordSuccess,
            RemoveLoginSuccess,
            RemovePhoneSuccess,
            Error
        }
        #endregion
    }
}