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
        //[HttpGet]
        public ActionResult Index()
        {
            //return View("~/Theme/Default/Index.cshtml");
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

            Test_MVC_XieEntities entity = new Test_MVC_XieEntities();
            Biz_MarketingInfo biz = new Biz_MarketingInfo { Xmmc = "某某某项目名称", Gcdd = "某项目地点" };
            entity.Biz_MarketingInfo.Add(biz);
            entity.SaveChanges();

            //DemoSiteEntities entity = new DemoSiteEntities();

            return this.Json(new { rdata = "~/home", success = true });
            //return View("~/Views/Account/Index.cshtml");
            //return View("~/Views/Account/Index.cshtml");
        }

        
        public ActionResult Register()
        {
            return View();
        }





        public ActionResult Default()
        {
            return View("~/Theme/Default/Register.cshtml");
            //return View();
        }





    }
}