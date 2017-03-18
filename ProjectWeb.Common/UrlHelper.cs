using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Web;

namespace ProjectWeb.Common
{
    public static class UrlHelper
    {
        private static string currVirtualPath = HttpRuntime.AppDomainAppVirtualPath.ToLower().Replace("/standard", "");
        private static string AssetHost = "";

        private static string projectVirtualPath
        {
            get
            {
                if (HttpContext.Current.Items["ProjectVirtualPath"] != null)
                {
                    return HttpContext.Current.Items["ProjectVirtualPath"].ToString().ToLower();//HZ.PBox.Config.ProjectVirtualPath()
                }
                else
                {
                    return string.Empty;
                }
            }
        }
        

        /// <summary>
        /// 读取父项目样式图片
        /// </summary>
        /// <param name="url">路径</param>
        /// <returns></returns>
        public static string GetTopAsset(string url)
        {
            return string.Format("{0}{1}", AssetHost, GetTopUrl(url));
        }

        /// <summary>
        /// 读取子项目样式图片
        /// </summary>
        /// <param name="url">路径</param>
        /// <returns></returns>
        public static string GetSubAsset(string url)
        {
            return string.Format("{0}{1}", AssetHost, GetSubUrl(url));
        }


        /// <summary>
        /// 读取父项目
        /// </summary>
        /// <param name="url">路径</param>
        /// <returns></returns>
        public static string GetTopUrl(string url)
        {
            if (!string.IsNullOrEmpty(projectVirtualPath))
            {
                currVirtualPath = currVirtualPath.Replace(projectVirtualPath, "");
            }

            if (HttpContext.Current.Items["LastAssetsVersion"] != null && (url.EndsWith(".css") || url.EndsWith(".js")))
            {
                url = url + (url.Contains("?") ? "&" : "?") + "v=" + HttpContext.Current.Items["LastAssetsVersion"];
            }

            return string.Format("{0}{1}", currVirtualPath, url.Replace("~/", "/"));
        }



        /// <summary>
        /// 读取子项目
        /// </summary>
        /// <param name="url">路径</param>
        /// <param name="module">模块:空表示读取公用资源</param>
        /// <returns></returns>
        public static string GetSubUrl(string url)
        {
            if (HttpContext.Current.Items["LastAssetsVersion"] != null && (url.EndsWith(".css") || url.EndsWith(".js")))
            {
                url = url + (url.Contains("?") ? "&" : "?") + "v=" + HttpContext.Current.Items["LastAssetsVersion"];
            }

            if (currVirtualPath == projectVirtualPath)
            {
                return string.Format("{0}{1}", projectVirtualPath, url.Replace("~/", "/"));
            }
            else
            {
                return string.Format("{0}/{1}{2}", currVirtualPath, projectVirtualPath, url.Replace("~/", "/"));
            }
        }



        /// <summary>
        /// 读取资源文件路径
        /// </summary>
        /// <param name="urlHelper"></param>
        /// <param name="url">路径</param>
        /// <param name="module">模块:空表示读取公用资源</param>
        /// <returns></returns>
        public static string GetThemeUrl(string url, bool isArea = false)
        {
            if (HttpContext.Current.Items["LastAssetsVersion"] != null && (url.EndsWith(".css") || url.EndsWith(".js")))
            {
                url = url + (url.Contains("?") ? "&" : "?") + "v=" + HttpContext.Current.Items["LastAssetsVersion"];
            }
            var theme = HttpContext.Current.Items["Theme"];
            return string.Format("{0}/{1}/Theme/{2}/{3}", currVirtualPath, isArea ? projectVirtualPath : "", theme, url).Replace("//", "/").Replace("//", "/");

        }

        public static string GetLoginThemeUrl(string url, bool isArea = false)
        {

            if (HttpContext.Current.Items["LastAssetsVersion"] != null && (url.EndsWith(".css") || url.EndsWith(".js")))
            {
                url = url + (url.Contains("?") ? "&" : "?") + "v=" + HttpContext.Current.Items["LastAssetsVersion"];
            }
            var theme = HttpContext.Current.Items.Contains("LoginTheme") && !string.IsNullOrEmpty(HttpContext.Current.Items["LoginTheme"].ToString()) ? HttpContext.Current.Items["LoginTheme"] : HttpContext.Current.Items["Theme"];
            return string.Format("{0}/{1}/Theme/{2}/{3}", currVirtualPath, isArea ? projectVirtualPath : "", theme, url).Replace("//", "/").Replace("//", "/");

        }
    }
}
