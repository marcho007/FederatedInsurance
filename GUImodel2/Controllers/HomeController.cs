using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GUImodel2.Controllers
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
        
        public ActionResult Overview()
        {
            ViewBag.Message = "Your Overview.";

            return View();
        }
        public ActionResult SubmitPR()
        {
            ViewBag.Message = "Perfomance Rate Form Submission.";

            return View();
        }
        public ActionResult RankStructure()
        {
            ViewBag.Message = "Your Rank Structure.";

            return View();
        }
        public ActionResult History()
        {
            ViewBag.Message = "Your Overview.";

            return View();
        }
    }
}