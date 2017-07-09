using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TongjiAssessment.Domain.Abstract;
using TongjiAssessment.Domain.Concrete;
using TongjiAssessment.Models;

namespace TongjiAssessment.Controllers
{
    public class AccountController : Controller
    {
        IAuthProvider authProvider;
        //private IAuthenticationManager AuthenticationManager { get { return HttpContext.GetOwinContext().Authentication; } }
        public AccountController(IAuthProvider authProvider)
        {
            this.authProvider = authProvider;
        }
        public ActionResult LoginOut()
        {
            FormsAuthentication.SignOut();
            return Redirect(Url.Action("Login", "Account")); ;
        } 
        public ViewResult Login()
        {
            return View();
        }
        // GET: Login
        [HttpPost]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if(authProvider.Authenticate(model.Username, model.Password))
                {
                    return Redirect(returnUrl ?? Url.Action("Add", "AddAssessment"));
                }
                else
                {
                    ModelState.AddModelError("", "用户名或密码输入错误！");
                    return View();
                }
            }
            return View();
        }
        
    }
}