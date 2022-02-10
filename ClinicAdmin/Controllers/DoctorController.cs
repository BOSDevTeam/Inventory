using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicAdmin.Controllers
{
    public class DoctorController : Controller
    {
        public ActionResult DoctorList()
        {
            return View();
        }

        public ActionResult DoctorSetup()
        {
            return View();
        }

        public ActionResult DoctorProfile()
        {
            return View();
        }

        public ActionResult DoctorSchedule()
        {
            return View();
        }
    }
}