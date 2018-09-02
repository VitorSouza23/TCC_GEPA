using Gepa.Business.Calendar;
using Gepa.Business.ClassPlans;
using Gepa.Business.SchoolClasses;
using Gepa.Business.Users;
using Gepa.Identity.Base.StartConfig;
using GepaManagement;
using GepaManagement.ServicesTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using System.Web.Mvc;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity;

namespace Gepa.Identity.Helpers
{
    public class BaseController : Controller
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

        protected override void Dispose(bool disposing)
        {
            
            if (disposing)
            {
                if (_userService != null)
                {
                    _userService.Dispose();
                    _userService = null;
                }

                if (_signInService != null)
                {
                    _signInService.Dispose();
                    _signInService = null;
                }

                if(_roleService != null)
                {
                    _roleService.Dispose();
                    _roleService = null;
                }
            }

            base.Dispose(disposing);
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