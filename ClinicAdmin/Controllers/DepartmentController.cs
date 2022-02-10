using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicAdmin.Controllers
{
    public class DepartmentController : Controller
    {
        public ActionResult DepartmentList()
        {
            return View();
        }

        public ActionResult DepartmentSetup()
        {
            return View();
        }
    }
}