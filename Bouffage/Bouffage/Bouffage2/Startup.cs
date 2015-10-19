using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bouffage2.Web.Startup))]
namespace Bouffage2.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
