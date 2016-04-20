using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Warid.Controllers
{
    public class sportsController : Controller
    {
        // GET: sports
        public ActionResult waridfootballclub()
        {
            return View();
        }


        public ActionResult waridsportsstation()
        {
            return View();
        }
    }
}