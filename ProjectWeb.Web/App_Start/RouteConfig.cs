using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjectWeb.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "account",
                url: "account/{action}",
                defaults: new { controller = "Account", action = "Index", id = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "form_page",
                url: "p/{url}/{id}",
                defaults: new { controller = "FormApi", action = "Page", id = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
