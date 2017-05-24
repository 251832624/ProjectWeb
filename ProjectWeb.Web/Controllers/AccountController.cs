using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ProjectWeb.BLL;
using ProjectWeb.Models;

namespace ProjectWeb.Web.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View("~/Theme/Default/Login.cshtml");
            //return View();
        }

        //public ActionResult Action()
        //{
        //    return View();
        //}



        public ActionResult Login()
        {
            //ViewBag.LoginState = "登录前。。。";
            //TestBLL bll = new TestBLL();
            //bll.TestMethod();
            //List<SysUser> users = bll.GetUser();
            return View("~/Theme/Default/Login.cshtml");
        }


        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            string LoginName = fc["LoginName"];
            string LoginPwd = fc["LoginPwd"];

            return View("~/Views/home/Index.cshtml");
            //return this.Json(new { rdata = "~/home", success = true });
            //return View("~/Views/Account/Index.cshtml");
            //return View("~/Views/Account/Index.cshtml");
        }

        
        public ActionResult Register()
        {
            return View();
        }





        public ActionResult Default()
        {
            return View("~/Theme/Default/Login.cshtml");
            //return View();
        }





    }
}