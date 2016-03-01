using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Mvc;
using DAL2;
using DAL2.Repository;

namespace Section13_L50.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Msg = (TempData["Msg"] != null) ? TempData["Msg"].ToString() : string.Empty;

            return View();
        }

        public ActionResult Insert(FormCollection fc)
        {
            Repository<Department> repDept = new Repository<Department>();

            Department dept = new Department()
            {
                Name = fc["Name"],
                HOD = fc["HOD"],
                Gender = fc["Gender"]
            };

            string msg;

            try
            {
                repDept.Insert(dept);
                msg = "Record Inserted";
            }
            catch
            {
                msg = "Record Not Inserted";
            }

            TempData["Msg"] = msg;

            //Move from one action to another action
            return RedirectToAction("Index");
        }


        public String Test()
        {
            return (TempData["Msg"] != null) ? TempData["Msg"].ToString() : string.Empty;

        }

    }
}
