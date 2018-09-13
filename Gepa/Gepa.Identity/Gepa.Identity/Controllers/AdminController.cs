using AutoMapper;
using Gepa.Identity.Base.Model;
using Gepa.Identity.Helpers;
using Gepa.Identity.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

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
            var model = new EditUserModel
            {
                Email = result.Email,
                UserId = result.Id,
                UserName = result.UserName
            };

            foreach (var role in result.Roles)
            {
                var r = await RoleService.FindByIdAsync(role.RoleId);
                model.RolesIds.Add(r.Id);
            }

            var allAvaiableRoles = (from allRoles in RoleService.Roles
                                    select new RoleModel { RoleId = allRoles.Id, RoleName = allRoles.Name }).ToList();
            model.AllAvailableRoles = allAvaiableRoles;

            return View("EditUserView", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SaveUserInformations(EditUserModel userModel)
        {

            ApplicationUser user = await UserService.FindByIdAsync(userModel.UserId);

            user.UserName = userModel.UserName;
            user.Email = userModel.Email;

            var actualRoles = user.Roles.ToList();
            var removedUserRoles = actualRoles.Where(r => userModel.RolesIds.Exists(rr => rr == r.RoleId) == false);
            var removedRoles = removedUserRoles.Select(r => RoleService.Roles.First(rr => rr.Id == r.RoleId)).ToList();
            var newRoles = userModel.RolesIds.Where(r => actualRoles.Exists(rr => rr.RoleId == r) == false);

            await UserService.UpdateAsync(user);
            await UserService.RemoveFromRolesAsync(user.Id, removedRoles.Select(r => r.Name).ToArray());
            await UserService.AddToRolesAsync(user.Id, newRoles.Select(r => RoleService.FindByIdAsync(r).Result.Name).ToArray());

            return RedirectToAction("AllUsersListView");

        }

        public ActionResult GetManagementRolesView()
        {
            var rolesModel = Mapper.Map<List<IdentityRole>, List<RoleModel>>(RoleService.Roles.ToList());
            return View("ManagementRolesView", rolesModel);
        }

        public async Task<ActionResult> EditRoleView(string roleId)
        {
            var role = await RoleService.FindByIdAsync(roleId);
            var model = Mapper.Map<IdentityRole, RoleModel>(role);
            return View("EditRoleView", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SaveRoleInformation(RoleModel roleModel)
        {
            if (ModelState.IsValid)
            {
                var role = await RoleService.FindByIdAsync(roleModel.RoleId);
                role.Name = roleModel.RoleName;
                await RoleService.UpdateAsync(role);
                return RedirectToAction("GetManagementRolesView");
            }

            return View("EditRoleView", roleModel);
            
        }

        public ActionResult NewRoleView()
        {
            return View("NewRoleView", new RoleModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SaveNewRole(RoleModel newRoleModel)
        {
            if (ModelState.IsValid)
            {
                var newRole = new IdentityRole { Name = newRoleModel.RoleName };
                await RoleService.CreateAsync(newRole);
                return RedirectToAction("GetManagementRolesView");
            }

            return View("NewRoleView", newRoleModel);
        }
    }
}