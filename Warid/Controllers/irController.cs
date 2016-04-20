using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Warid.Controllers
{
    public class irController : Controller
    {
        // GET: ir
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult postpaid()
        {
            return View();
        }
        
        public ActionResult prepaid()
        {
            return View();
        }
    }
}