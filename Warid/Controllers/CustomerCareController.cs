using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Warid.Controllers
{
    public class CustomerCareController : Controller
    {
        // GET: CustomerCare
        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}