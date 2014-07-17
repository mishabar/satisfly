using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using EliteRoute.Services;
using EliteRoute.Services.Exceptions;
using EliteRoute.Services.Tokens;
using EliteRoute.Web.Models;

namespace EliteRoute.Web.Controllers
{
    public class AccountController : Controller
    {
        private IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public ActionResult SignIn()
        {
            SignInModel model = new SignInModel { InvalidPassword = false };
            return View(model);
        }

        [HttpPost]
        public ActionResult SignIn(SignInModel model)
        {
            if (ModelState.IsValid)
            {
                AccountToken token = _accountService.Authenticate(model.Email, model.Password);
                if (token != null)
                {
                    HttpCookie cookie = FormsAuthentication.GetAuthCookie(token.Email, false);
                    Response.Cookies.Add(cookie);
                    return Redirect("/Account");
                }
                else
                {
                    model.InvalidPassword = true;
                }
            }
            return View(model);
        }

        [HttpGet]
        [Authorize]
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("/");
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(SignUpModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    AccountToken token = _accountService.Create(model.Email, model.Password, model.FirstName, model.LastName, model.Birthdate, new string[] { model.Address1, model.Address2 });
                    HttpCookie cookie = FormsAuthentication.GetAuthCookie(token.Email, false);
                    Response.Cookies.Add(cookie);
                    return Redirect("/Account");
                }
            }
            catch (DuplicateAccountException)
            {
                ModelState.AddModelError("Email", "Email already in use");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult ForgotPassword() 
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public ActionResult Index()
        {
            AccountToken token = _accountService.Get(User.Identity.Name);
            return View(token);
        }
    }
}
