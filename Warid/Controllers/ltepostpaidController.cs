using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Warid.Controllers
{
    public class ltepostpaidController : Controller
    {
        // GET: ltepostpaid
        public ActionResult ltepostpaidplans()
        {
            return View();
        }

        public ActionResult ltepostpaidsharedinternetplans()
        {
            return View();
        }
    }
}