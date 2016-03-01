using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL2;
using DAL2.Repository;

namespace Section14EF.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {

            Department dept = new Department()
            {
                Name = "TL",
                HOD = "Cesar",
                Gender = "M"

            };

            return View(dept);
        }


        public ActionResult Insert(Department dept)
        {
            Repository<Department> repDept = new Repository<Department>();

            repDept.Insert(dept);

            return RedirectToAction("Index");
        }

    }
}
