using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductApp.Web.Startup))]
namespace ProductApp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
