using Gepa.Entities.Framework.Entities.Users;
using Gepa.Identity.Base.Model;
using Gepa.Resources;
using Gepa.Site.Helpers;
using Gepa.Site.Models.Account;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Gepa.Site.Controllers
{
    [Authorize]
    public class AccountController : GepaBaseController
    {
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View("_Login", new LoginViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View("_Login", model);

            var result = await SignInService.PasswordSignInAsync(model.EmailOrUserName, model.Password, isPersistent: false, shouldLockout: false);
            switch (result)
            {
                case SignInStatus.Success:
                    return RedirectToAction("Index", "Dashboard");
                case SignInStatus.Failure:
                default:
                    ModelState.AddModelError("", Language.InvalidLoginError);
                    ModelState.AddModelError(nameof(model.EmailOrUserName), Language.MaybeTheUserNameDoesNotExistError);
                    ModelState.AddModelError(nameof(model.Password), Language.MaybeThePasswordBeIncorrectError);
                    return View("_Login", model);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        public ActionResult Register()
        {
            return View("_Register", new RegisterViewModel());
        }

        public ActionResult RecoverPassword()
        {
            return View("_RecoverPassword");
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult ExternalLogin(string provider)
        {
            return new ChallengeResult(provider, Url.Action("ExternalLoginCallback", "Account"));
        }

        [AllowAnonymous]
        public async Task<ActionResult> ExternalLoginCallback()
        {
            var loginInfo = await AuthenticationManager.GetExternalLoginInfoAsync();
            if (loginInfo == null)
            {
                return RedirectToAction("Login");
            }

            var result = await SignInService.ExternalSignInAsync(loginInfo, isPersistent: false);
            switch (result)
            {
                case SignInStatus.Success:
                    return RedirectToAction("Index", "Dashboard");
                case SignInStatus.Failure:
                default:
                    ViewBag.LoginProvider = loginInfo.Login.LoginProvider;
                    return View("ExternalLoginConfirmation", new ExternalLoginConfirmationViewModel { Email = loginInfo.Email });
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ExternalLoginConfirmation(ExternalLoginConfirmationViewModel model)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Dashboard");
            }

            if (ModelState.IsValid)
            {
                // Obter as informações sobre o usuário do provedor de logon externo
                var info = await AuthenticationManager.GetExternalLoginInfoAsync();
                if (info == null)
                {
                    return View("ExternalLoginFailure");
                }
                var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
                var result = await UserService.CreateAsync(user);
                if (result.Succeeded)
                {
                    result = await UserService.AddLoginAsync(user.Id, info.Login);
                    if (result.Succeeded)
                    {
                        await SignInService.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                        var teacher = new Teacher { UserId = user.Id };
                        TeacherService.InsertTeacher(teacher);
                        return RedirectToAction("Index", "Dashboard");
                    }
                }
                AddErrors(result);
            }

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
                var result = await UserService.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await SignInService.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                    var teacher = new Teacher { UserId = user.Id };
                    TeacherService.InsertTeacher(teacher);
                    
                    return RedirectToAction("Index", "Dashboard");
                }
                AddErrors(result);
            }
            return View(model);
        }
    }
}