using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopAppK300.Web.Startup))]
namespace ShopAppK300.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
