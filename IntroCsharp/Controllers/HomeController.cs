using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroCsharp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Yamile Solis";
            ViewBag.Grupo = "IDGS 804";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "IDGS 804";

            return View();
        }
    }
}