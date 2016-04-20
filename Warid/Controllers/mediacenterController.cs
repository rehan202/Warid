using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Warid.Controllers
{
    public class mediacenterController : Controller
    {
        // GET: mediacenter
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult corporatemagazine()
        {
            return View();
        }

        public ActionResult events()
        {
            return View();
        }

        public ActionResult pressrelease()
        {
            return View();
        }

        public ActionResult tvc()
        {
            return View();
        }
    }
}