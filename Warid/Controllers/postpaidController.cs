using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Warid.Controllers
{
    public class postpaidController : Controller
    {
        // GET: postpaid
        public ActionResult Index()
        {
            // /postpaid/Index
            return View();
        }     
        public ActionResult handsetoffers()
        {
            return View();
        }
        public ActionResult internationaldialing()
        {
            return View();
        }
        public ActionResult internationalroaming()
        {
            return View();
        }
        public ActionResult offers()
        {
            return View();
        }
        public ActionResult onlinebillpayment()
        {
            // this view does not exist in actual running site inside of PostPaid...
            return View();
        }
        public ActionResult packagecalculator()
        {
            // this option does not finding online website.
            return View();
        }
        public ActionResult packages()
        {
            return View();
        }
        public ActionResult services()
        {
            return View();
        }
        public ActionResult taxexemptioncertificate()
        {
            return View();
        }
        public ActionResult mobileinternet()
        {
            return View();
        }
        
        
    }
}