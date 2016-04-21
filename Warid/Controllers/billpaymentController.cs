using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Warid.Controllers
{
    public class billpaymentController : Controller
    {
        public ActionResult billbyemail()
        {
            return View();
        }
        public ActionResult billpaymentviaatm()
        {
            return View();
        }
        public ActionResult billpaymentviascratchcard()
        {
            return View();
        }
        public ActionResult cashtodirectdebit()
        {
            return View();
        }
        public ActionResult onlinebillpayment()
        {
            return View();
        }
        public ActionResult onlinebillpaymentviabank()
        {
            return View();
        }
        public ActionResult paymentviasting()
        {
            return View();
        }
        public ActionResult waridload()
        {
            return View();
        }
    }
}