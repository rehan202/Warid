using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Warid.Controllers
{
    public class musicController : Controller
    {
        // GET: music

         
        public ActionResult backgroundmusic()
        {
            return View();
        }

        public ActionResult callertunes()
        {
            return View();
        }

        public ActionResult musicstation()
        {
            return View();
        }


        public ActionResult waridmusicclub()
        {
            return View();
        }


        public ActionResult waridmusicstream()
        {
            return View();
        }


        public ActionResult waridrockstar()
        {
            return View();
        }
    }
}