using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicAdmin.Controllers
{
    public class ItemController : Controller
    {
        public ActionResult ItemList()
        {
            return View();
        }

        public ActionResult ItemSetup()
        {
            return View();
        }
    }
}