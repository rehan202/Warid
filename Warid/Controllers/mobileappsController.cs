using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Warid.Controllers
{
    public class mobileappsController : Controller
    {
        // GET: mobileapps
        public ActionResult waridislamicapp()
        {
            return View();
        }
        public ActionResult waridmobileapps()
        {
            return View();
        }
        public ActionResult waridmobileworld()
        {
            return View();
        }

        public ActionResult termsandconditions()
        {
            return View();
        }

    }
}