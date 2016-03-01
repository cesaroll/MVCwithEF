using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using S16_L63_Authorization.Models;

namespace S16_L63_Authorization.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            OrgEntities oe = new OrgEntities();

            var count = oe.Users.Count(x => x.UserName == user.UserName && x.Password == user.Password);

            if (count == 0)
            {
                ViewBag.Message = "Invalid User";
                return View();

            }
            else
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                return RedirectToAction("Index", "Home");
            }

        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}