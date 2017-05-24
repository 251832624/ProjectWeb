using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectWeb.Web.Startup))]
namespace ProjectWeb.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
