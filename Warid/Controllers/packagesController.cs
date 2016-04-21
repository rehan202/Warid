using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Warid.Controllers
{
    public class packagesController : Controller
    {
        public ActionResult newpostpaidplans()
        {
            return View();
        }
        public ActionResult oldpostpaidplans()
        {
            return View();
        }
    }
}