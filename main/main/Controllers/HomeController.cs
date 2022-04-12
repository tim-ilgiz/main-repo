using first_sub;
using nuget_lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace main.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var any = new AnyClass();
            ViewBag.Message = $"{any.ReturnAnyThing()}";
            return View();
        }

        public ActionResult Contact()
        {
            var any = new AnyNugetClass();
            ViewBag.Message = $"{any.ReturnAnyNugetString()}";
            return View();
        }
    }
}