using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Warid.Controllers
{
    public class locationbasedservicesController : Controller
    {
        // GET: locationbasedservices
        public ActionResult mybuddy()
        {
            return View();
        }
      
             public ActionResult mycorp()
        {
            return View();
        }
        public ActionResult myfamily()
        {
            return View();
        }
      
              public ActionResult myguide()
        {
            return View();
        }
    }
}