using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FTrans.SupplierSuccess.Domain;
using FTrans.SupplierSuccess.ViewModels;
using FTrans.SupplierSuccess.Core;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            var domain = ContextFactory.Current.GetDoamin<SystemDomain>(null);
            var model = domain.AuthenticateUser(loginViewModel);

            Session["CUrrentUser"] = model;

            ContextFactory.Current.ApplicationUser = model;

            return RedirectToAction("Index", new { Controller = "Sponsor" });
        }
    }
}