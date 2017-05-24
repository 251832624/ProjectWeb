using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectWeb.Web.Controllers
{

    /// <summary>
    /// 页面跳转控制类
    /// </summary>
    public class FormController : Controller
    {



        /// <summary>
        /// 页面跳转 默认列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult DefaultPage()
        {
            return View();
        }


        /// <summary>
        /// 页面跳转 方法
        /// </summary>
        /// <returns></returns>
        public ActionResult Page()
        {
            return View();
        }

    }
}