using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicAdmin.Controllers
{
    public class PatientController : Controller
    {
        public ActionResult PatientList()
        {
            return View();
        }

        public ActionResult PatientSetup()
        {
            return View();
        }
    }
}