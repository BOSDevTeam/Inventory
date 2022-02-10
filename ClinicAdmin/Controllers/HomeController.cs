using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicAdmin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}