using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Warid.Controllers
{
    public class waridmifiController : Controller
    {
        // GET: waridmifi
        public ActionResult mifidetails()
        {
            return View();
        }

        public ActionResult mifistores()
        {
            return View();
        }
    }
}