using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;

namespace LogAnalysis.MongoDB.Web.Controllers
{
    public class HomeController : Controller
    {
        private ILog _logger;

        public HomeController(ILog logger)
        {
            _logger = logger;
        }
        public ActionResult Index()
        {
            _logger.Debug("Hello");
            return View();
        }

        public ActionResult Index2()
        {
            _logger.Debug("Hello");
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
    }
}