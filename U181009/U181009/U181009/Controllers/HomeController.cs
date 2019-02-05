using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace U181009.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning" : "Good Afternoon"; //ternery expression
            return View();
        }

        [HttpGet]
        public ViewResult Approval()
        {

            return View();
        }
        [HttpPost]
        public ViewResult Approval(Models.ConsensualAgreement ca)
        {
            if (ModelState.IsValid == true)
            {
                return View("Thanks", ca);
            }
            else
            {
                return View();
            }
        }
    }
}