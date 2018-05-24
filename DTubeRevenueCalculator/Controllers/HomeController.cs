using DTubeRevenueCalculator.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DTubeRevenueCalculator.Controllers
{
    public class HomeController : Controller
    {
        DRepo repo = new DRepo();
        public ActionResult Index()
        {
            
            return View(repo);
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
    }
}