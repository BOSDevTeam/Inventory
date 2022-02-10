using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicAdmin.Controllers
{
    public class AppointmentController : Controller
    {
        public ActionResult AppointmentList()
        {
            return View();
        }

        public ActionResult AppointmentSetup()
        {
            return View();
        }

        public ActionResult ViewAppointment()
        {
            return View();
        }
    }
}