using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicAdmin.Controllers
{
    public class DoctorScheduleController : Controller
    {
        public ActionResult DoctorScheduleList()
        {
            return View();
        }

        public ActionResult DoctorScheduleSetup()
        {
            return View();
        }
    }
}