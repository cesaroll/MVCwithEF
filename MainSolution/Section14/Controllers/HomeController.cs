using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL2;
using DAL2.Repository;
using Section14.Models;

namespace Section14.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            DepartmentModel deptModel = new DepartmentModel()
            {
                Name = "TECHLEAD",
                HOD = "Cesar",
                Gender = "M"
            
            };

            return View(deptModel);
        }


        public ActionResult Insert(DepartmentModel deptModel)
        {
            Repository<Department> repDept = new Repository<Department>();

            repDept.Insert(new Department()
            {
                Name = deptModel.Name,
                HOD = deptModel.HOD,
                Gender = deptModel.Gender
            });

            return RedirectToAction("Index");
        }

    }
}
