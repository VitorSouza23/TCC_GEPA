using Gepa.Identity.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Gepa.Identity.Base.StartConfig;
using Microsoft.AspNet.Identity.EntityFramework;
using Gepa.Identity.Base.Commun;
using Gepa.Entities.Framework.Entities.Users;
using Gepa.Business.Users;
using Gepa.Management.Services;
using Gepa.Management.Services.ServicesTypes;
using System.Threading.Tasks;

namespace Gepa.Site.Helpers
{
    public static class Helper
    {
        public static ApplicationUser GetCurrentUser()
        {
            var userManager = HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            return userManager.FindById(HttpContext.Current.User.Identity.GetUserId());
        }

        public static List<IdentityUserRole> GetCurrentUserRoles()
        {
            var roleManager = HttpContext.Current.GetOwinContext().Get<ApplicationRoleManager>();
            var userManager = HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var currentUser = userManager.FindById(HttpContext.Current.User.Identity.GetUserId());
            return (from role in currentUser.Roles
                    where role.UserId == currentUser.Id
                    select role).ToList();
        }

        public static bool IsAdminCurrentUser()
        {
            var roleManager = HttpContext.Current.GetOwinContext().Get<ApplicationRoleManager>();
            var userManager = HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var currentUser = userManager.FindById(HttpContext.Current.User.Identity.GetUserId());
            var result = (from role in currentUser.Roles
                          where role.UserId == currentUser.Id && role.RoleId == GepaRoles.ADMIN_ROLE_ID
                          select role).ToList();
            return result.Count > 0;
        }

        public static bool IsCurrentUserLoggedIn()
        {
            return HttpContext.Current.User != null && HttpContext.Current.User.Identity.IsAuthenticated;
        }

        public static async Task<Teacher> GetCurrentTeacherAsync()
        {
            Teacher teacher = null;
            if (IsCurrentUserLoggedIn())
            {
                ITeacherService _teacherService = (ITeacherService)GepaServices.Instance.GetService(GepaServicesTypes.TeacherService);
                teacher = await _teacherService.FindTeacherByUserIdAsync(HttpContext.Current.User.Identity.GetUserId());
            }
            return teacher;

        }
    }
}