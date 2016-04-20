using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Warid.Controllers
{
    public class selfservicesController : Controller
    {
        // GET: selfservices
        public ActionResult calldetails()
        {
            return View();
        }

        public ActionResult freeassistanceservice()
        {
            return View();
        }
        public ActionResult ivr100()
        {
            return View();
        }

        public ActionResult ivrflows()
        {
            return View();
        }
        public ActionResult prepaidhelpservices()
        {
            return View();
        }

        public ActionResult shortcodeservices()
        {
            return View();
        }
        public ActionResult smsbasedselfservices()
        {
            return View();
        }

        public ActionResult startstopservices()
        {
            return View();
        }

    }
}