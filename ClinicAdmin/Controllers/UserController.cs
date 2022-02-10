using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicAdmin.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult ChangePassword()
        {
            return View();
        }

        public ActionResult UserList()
        {
            return View();
        }

        public ActionResult UserSetup()
        {
            return View();
        }

        public ActionResult UserProfile()
        {
            return View();
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }
    }
}