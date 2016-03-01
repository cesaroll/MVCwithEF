using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL2;
using DAL2.Repository;

namespace Section13.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Repository<MyTable> myTabRep = new Repository<MyTable>();

            ViewBag.MyTabRecs = myTabRep.GetAll();

            return View();
        }

        public ActionResult Read(int id)
        {
            Repository<MyTable> myTableRep = new Repository<MyTable>();

            MyTable myTable = myTableRep.GetById(id);

            ViewBag.MyTable = myTable;

            return View("Index");
        }

    }
}
