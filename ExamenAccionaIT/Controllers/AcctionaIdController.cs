using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenAccionaIT.Controllers
{
    public class AcctionaIdController:Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult NombreProvincias()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}