using Gepa.Identity.Base.StartConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Gepa.Identity.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Gepa.Identity.Helpers;
using System.Threading.Tasks;

namespace Gepa.Identity.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : BaseController
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AllUsersListView()
        {
            var usersList = (from user in UserService.Users
                             select new
                             {
                                 UserId = user.Id,
                                 UserName = user.UserName,
                                 Email = user.Email,
                                 RolesNames = (from userRoles in user.Roles
                                             join role in RoleService.Roles on userRoles.RoleId
                                             equals role.Id
                                             select role.Name).ToList()
                             }).ToList().Select(p => new UsersModel
                             {
                                 UserId = p.UserId,
                                 UserName = p.UserName,
                                 Email = p.Email,
                                 RolesNames = string.Join(",", p.RolesNames)
                             });
            return View(usersList);
        }

        public async Task<ActionResult> EditUserView(string userId)
        {
            var result = await UserService.FindByIdAsync(userId);
            var model = new UsersModel
            {
                Email = result.Email,
                UserId = result.Id,
                UserName = result.UserName
            };

            var roles = new List<string>();
            foreach(var role in result.Roles)
            {
                var r = await RoleService.FindByIdAsync(role.RoleId);
                roles.Add(r.Name);
            }

            model.RolesNames = string.Join(",", roles);
            return View("EditUserView", model);
        }
    }
}