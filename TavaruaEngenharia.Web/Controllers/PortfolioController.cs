using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TavaruaEngenharia.Web.Controllers
{
    public class PortfolioController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Infra()
        {
            return View();
        }

        public ActionResult Urbanism()
        {
            return View();
        }

        public ActionResult Architecture()
        {
            return View();
        }
    }
}