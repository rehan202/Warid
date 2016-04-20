using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Warid.Controllers
{
    public class balancetransferservicesController : Controller
    {
        // GET: balancetransferservices
        public ActionResult balancerequest()
        {
            return View();
        }
        public ActionResult posttopostbalancetransfer()
        {
            return View();
        }

        public ActionResult posttoprebalancetransfer()
        {
            return View();
        }

        public ActionResult pretopostbalancetransfer()
        {
            return View();
        }

        public ActionResult pretoprebalancetransfer()
        {   
            return View();
        }

        public ActionResult sponsorme()
        {
            return View();
        }
    }
}