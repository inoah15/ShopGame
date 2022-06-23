using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameSellMVc.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult AdminLogin()
        {
            return View();
        }
        public ActionResult UserLogin()
        {
            return View();
        }
        public ActionResult CreateAccount()
        {
            return View();
        }
    }
}