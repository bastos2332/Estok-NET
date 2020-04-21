using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace src.Controllers
{
    public class GraficoDefaultController : Controller
    {
        // GET: GraficoDefault
        public ActionResult EntradaSaidaMes()
        {
            return View();
        }

        public ActionResult PerdaMes()
        {
            return View();
        }
    }
}