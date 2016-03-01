using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Section10.Controllers
{
    public class DepartmentController : Controller
    {
        public string GetInfo()
        {
            return "Welcome to Cesar MVC Course";
        }

        public string GetInfoWithDate()
        {
            return GetInfo() + " " + DateTime.Now.ToString();
        }

        public string Index()
        {
            return GetInfo() + " From Default Action";
        }

    }
}
