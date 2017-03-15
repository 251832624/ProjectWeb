using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectWeb.Web.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Action()
        {
            return View();
        }



        public ActionResult Login()
        {
            ViewBag.LoginState = "登录前。。。";
            return View();
        }


        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            string LoginName = fc["LoginName"];
            string LoginPwd = fc["LoginPwd"];

            ViewBag.LoginState = LoginName + "登录后。。。";
            return View();
        }

        
        public ActionResult Register()
        {
            return View();
        }















    }
}