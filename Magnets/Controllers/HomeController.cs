﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Magnets.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Ändern Sie diese Vorlage als Schnelleinstieg in Ihre ASP.NET MVC-Anwendung.";

            // check

            return View();
        }

        public ActionResult Tour()
        {
            ViewBag.Message = "Ihre App-Beschreibungsseite.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Ihre Kontaktseite.";

            return View();
        }
    }
}
