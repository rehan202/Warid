using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Warid.Controllers
{
    public class mobileinternetController : Controller
    {
        // GET: mobileinternet
        public ActionResult WaridSocialPack()
        {
            return View();
        }
        public ActionResult mobileinternetbuckets()
        {
            return View();
        }
        public ActionResult internetsettings()
        {
            return View();
        }

        public ActionResult prepaidsharedinternetplans()
        {
            return View();
        }
    }
}