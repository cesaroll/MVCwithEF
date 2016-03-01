using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S17_L68_AjaxActionLink.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.MyDate = DateTime.Now.ToString();

            return View();
        }

        public ActionResult AjaxReload()
        {
            ViewBag.MyDate = DateTime.Now.ToString();
            return PartialView();
        }
    }
}