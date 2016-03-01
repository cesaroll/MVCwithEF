using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL2;
using DAL2.Repository;

namespace S14_L55_MasterDetails.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        private Repository<Department> deptRep = new Repository<Department>();

        public ActionResult Index()
        {
            return View(deptRep.GetAll().ToList());
        }

        public ActionResult Details(int id)
        {
            return View(deptRep.GetById(id));
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(deptRep.GetById(id));
        }

        [HttpPost]
        public ActionResult Edit(Department dept)
        {
            deptRep.Update(dept);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(deptRep.GetById(id));
        }

        [HttpPost]
        public ActionResult Delete(Department dept)
        {
            deptRep.Delete(dept);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Department dept)
        {
            deptRep.Insert(dept);
            return RedirectToAction("Index");
        }
    }

}
