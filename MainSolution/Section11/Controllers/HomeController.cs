using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL2;
using DAL2.Repository;

namespace Section10.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        //public ViewResult MyActionSubmit(string name, int age)
        //{
        //    Repository<MyTable> myTable = new Repository<MyTable>();

        //    myTable.Insert(new MyTable(){Name=name, Age=age});

        //    return View();
        //}

        public ViewResult MyActionSubmit(FormCollection fc)
        {
            string name = fc["Name"].ToString();
            int age = 0;

            int.TryParse(fc["Age"].ToString(), out age);

            Repository<MyTable> myTable = new Repository<MyTable>();

            myTable.Insert(new MyTable() { Name = name, Age = age });

            return View();
        }
    }
}
