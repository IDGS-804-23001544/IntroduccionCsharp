using IntroCsharp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntroCsharp.Models;

namespace IntroCsharp.Controllers
{
    public class MultiplicacionController : Controller
    {
        // GET: Multiplicacion
        public ActionResult MultSumas(MultSumas mul)
        {
            mul.Multiplicar();

            return View(mul);
        }
    }
}