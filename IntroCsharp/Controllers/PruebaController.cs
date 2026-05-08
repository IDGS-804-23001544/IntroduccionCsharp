using IntroCsharp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntroCsharp.Services;
using IntroCsharp.Models;

namespace IntroCsharp.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba
        public ActionResult Index()
        {
            ViewBag.Message = "Yamile Solis";

            return View();
        }


        public ActionResult Suma()
        {
            return View();
        }

        //POST
        [HttpPost]
        public ActionResult Suma(string x, string y, string r1)
        {
            int res = Convert.ToInt16(x) + Convert.ToInt16(y);
            ViewBag.Res = Convert.ToString(res);

            return View();
        }


        public ActionResult MuestraPeliculas()
        {
            var peliculasService = new PeliculasService();
            var model = peliculasService.ObtenerPelicula();

            return View(model);

        }

        public ActionResult Calculos(OperasBas op)
        {
            op.Suma();
            return View(op);
        }


    }
}




