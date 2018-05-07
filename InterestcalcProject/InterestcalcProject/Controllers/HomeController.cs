using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InterestcalcProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Calculate()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Calculate(float amount, float years,float rate)
        {
            float interest = 0;
            interest = amount * years * (rate / 100);
            ViewBag.Interest = interest;
            ViewBag.Message = "Interest calculated successfully";
            return View("Calculate");
        }
    }
}