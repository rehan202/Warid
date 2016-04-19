using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Warid.Controllers
{
    public class entertainmentController : Controller
    {
        // GET: entertainment
        public ActionResult waridlive()
        {
            return View();
        }
        public ActionResult waridradiostation()
        {
            return View();
        }
        public ActionResult waridvoiler()
        {
            return View();
        }
        public ActionResult dramaline()
        {
            return View();
        }
    }
}