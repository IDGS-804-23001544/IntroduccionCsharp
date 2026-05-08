using IntroCsharp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntroCsharp.Models;

namespace IntroCsharp.Controllers
{
    public class DistanciaController : Controller
    {
        // GET: Distancia
        public ActionResult CalcularDis(CalcularDis dis)
        {
            dis.Distancia();

            return View(dis);
        }
    }
}