using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor.Parser;
using S15_L59_Validation.Models;

namespace S15_L59_Validation.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            SaveQualificationsInViewBag();

            return View();
        }

        private void SaveQualificationsInViewBag()
        {
            List<SelectListItem> items = new List<SelectListItem>();

            items.Add(new SelectListItem() {Text = "", Value = "", Selected = true});
            items.Add(new SelectListItem() {Text = "B.Tech", Value = "0"});
            items.Add(new SelectListItem() {Text = "M.Tech", Value = "1"});
            items.Add(new SelectListItem() {Text = "MCA", Value = "2"});
            items.Add(new SelectListItem() {Text = "Ph.D", Value = "3"});

            ViewBag.Qualifications = items;

        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
                return View();
            else
            {
                SaveQualificationsInViewBag();
                return View("Index");
            }
        }
    }
}