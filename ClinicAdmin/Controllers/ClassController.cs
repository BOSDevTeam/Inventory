using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicAdmin.Controllers
{
    public class ClassController : Controller
    {
        public ActionResult ClassList()
        {
            return View();
        }

        public ActionResult ClassSetup()
        {
            return View();
        }
    }
}